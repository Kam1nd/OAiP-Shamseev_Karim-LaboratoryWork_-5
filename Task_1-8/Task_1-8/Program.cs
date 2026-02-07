using System;
class Program
{
    static void Main()
    {
        Range interval = new Range();

        interval.Read();

        interval.Display();

        Console.Write("\nВведите число для проверки: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ошибка: ввод не может быть пустым.");
            return;
        }

        if (int.TryParse(input, out int number))
        {
            interval.rangecheck(number);
        }
        else
        {
            Console.WriteLine("Ошибка: введено не целое число.");
            return;
        }
    }
}