
namespace pr2._1;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите номер задания (1-3): ");
            switch (int.Parse(Console.ReadLine()!))
            {
                case 1:
                    FirstTask();
                    break;
                case 2:
                    SecondTask();
                    break;
                case 3:
                    ThirdTask();
                    break;
                default:
                    Console.WriteLine("Невозможный номер.");
                    break;
            }
        }
        catch
        {
            Console.WriteLine("Неверные данные.");
        }
    }


//------------ FIRST TASK -------------

    static void FirstTask()
    {
        try
        {
            Console.Write("Введите строку J (драгоценности): ");
            string j = Console.ReadLine()!;
            Console.Write("Введите строку S (камни): ");
            string s = Console.ReadLine()!;

            int result = 0;

            for (int i = 0; i < j.Length; ++i)
            {
                for (int n = 0; n < s.Length; ++n)
                {
                    if (j[i] == s[n])
                    {
                        ++result;
                    }
                }
            }
            Console.WriteLine($"Количество драгоценностей в камнях: {result}");
        }
        catch
        {
            Console.WriteLine("Возникла ошибка!");
        }
    }


//------------ SECOND TASK -------------

    static void SecondTask()
    {
        try
        {
            Console.Write("Введите целочисленный массив (candidates)\n(Разделяйте числа пробелами): ");
            List<int> candidates = new List<int>(Console.ReadLine()!.Split().Select(number => int.Parse(number)).ToArray());
            Console.Write("Введите цель (target): ");
            int target = int.Parse(Console.ReadLine()!);

            candidates.Sort();

            GoalFind(new List<int>(), candidates, target, new List<List<int>>());

            if (candidates.Sum() < target)
            {
                Console.Write("Комбинации не найдены.");
            }
        }
        catch
        {
            Console.WriteLine("Возникла ошибка!");
        }
    }

    static void GoalFind(List<int> combination, List<int> candidates, int target, List<List<int>> result)
    {
        if (combination.Sum() == target)
        {
            bool isSpecial = true;
            for (int i = 0; i < result.Count; ++i)
            {
                if (Enumerable.SequenceEqual(result[i], combination))
                {
                    isSpecial = false;
                }
            }

            if (isSpecial)
            {
                result.Add(combination);
                Console.Write($"[");

                for (int i = 0; i < combination.Count; ++i)
                {
                    Console.Write($" {combination[i]} ");
                }

                Console.WriteLine(']');
            }
        }

        if (combination.Sum() >= target)
        {
            return;
        }

        for (int i = 0; i < candidates.Count; ++i)
        {
            List<int> newCandidates = new List<int>();

            for (int j = i + 1; j < candidates.Count; ++j)
            {
                newCandidates.Add(candidates[j]);
            }

            List<int> reCombination = new List<int>(combination) { candidates[i] };
            GoalFind(reCombination, newCandidates, target, result);
        }
    
    }


// ------------- THIRD TASK ---------------

    static void ThirdTask()
    {
        try
        {
            Console.Write("Введите целочисленный массив (nums)\n(Разделяйте числа пробелами): ");
            int[] nums = Console.ReadLine()!.Split().Select(number => int.Parse(number)).ToArray();
            bool result = false;
            
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i] == nums[i + 1])
                {
                    result = true;
                }
            }

            Console.WriteLine(result); //НЕОБХОДИМО вернуть А НЕ распечатать
            //return;
        }
        catch
        {
            Console.WriteLine("Возникла ошибка");
        }
    }
}