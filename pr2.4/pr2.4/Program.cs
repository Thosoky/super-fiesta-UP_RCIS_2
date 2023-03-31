
namespace pr2._4;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите римское число: ");
            string number = Console.ReadLine()!.ToUpper();
            int result = 0;

            foreach (char letter in number)
            {
                result += ConvertLetterToNumber(letter);
            }

            if (number.Contains("IV") || number.Contains("IX"))
            {
                result -= 2;
            }

            if (number.Contains("XL") || number.Contains("XC"))
            {
                result -= 20;
            }

            if (number.Contains("CD") || number.Contains("CM"))
            {
                result -= 200;
            }

            Console.WriteLine(result);
        }
        catch
        {
            Console.WriteLine("Неверное значение.");
        }
    }

    static int ConvertLetterToNumber(char letter)
    {
        switch (letter)
        {
            case 'M':
            {
                return 1000;
            }
            case 'D':
            {
                return 500;
            }
            case 'C':
            {
                return 100;
            }
            case 'L':
            {
                return 50;
            }
            case 'X':
            {
                return 10;
            }
            case 'V':
            {
                return 5;
            }
            case 'I':
            {
                return 1;
            }
            default:
            {
                throw new Exception("Возникла ошибка!");
            }
        }
    }
}