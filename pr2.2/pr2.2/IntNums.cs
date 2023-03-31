namespace pr2._2;

public class IntNums
{
    public int FirstNum { get; set; }
    public int SecondNum { get; set; }

    public IntNums(int first, int second)
    {
        FirstNum = first;
        SecondNum = second;
    }
    public IntNums() {}
    public void Print(int a, int b)
    {
        Console.WriteLine($"Первое число: {a} \nВторое число: {b}");
    }

    public Tuple<int, int> changeNum(int a, int b)
    {
        Console.WriteLine("Что вы хотите сделать:\n1. Изменить первое число\n2. Изменить второе число\n3. Изменить оба числа");
        string num = Console.ReadLine()!;
        if (num == "1")
        {
            Console.Write("Введите первое число:");
            a = int.Parse(Console.ReadLine()!);
        }
        else if (num == "2")
        {
            Console.Write("Введите второе число:");
            b = int.Parse(Console.ReadLine()!);
        }
        else
        {
            Console.Write("Введите первое число:");
            a = int.Parse(Console.ReadLine()!);
            Console.Write("Введите второе число:");
            b = int.Parse(Console.ReadLine()!);
        }
        return Tuple.Create(a, b);
    }

    public void Summa(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Сумма чисел: {sum}");
    }

    public void Max(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine($"Наибольшее число = {a}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число = {b}");
        }
    }
}