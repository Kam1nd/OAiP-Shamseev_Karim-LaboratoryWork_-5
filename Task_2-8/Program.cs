using System;
class Program
{
    static void Main()
    {
        Range interval = new Range();

        // Ввод данных
        interval.Read();

        // Вывод интервала
        interval.Display();

        // Ввод числа для проверки
        Console.Write("\nВведите число для проверки: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ошибка: ввод не может быть пустым.");
            return;
        }

        if (int.TryParse(input, out int number))
        {
            bool result = interval.rangecheck(number);
            Console.WriteLine($"Число {number} {(result ? "принадлежит" : "НЕ принадлежит")} интервалу.");
        }
        else
        {
            Console.WriteLine("Ошибка: введено не целое число.");
            return;
        }

        // Демонстрация граничных случаев
        Console.WriteLine("\nПроверка граничных значений:");
        Console.WriteLine($"  {interval.first} (левая граница): {interval.rangecheck(interval.first)}");
        Console.WriteLine($"  {interval.second} (правая граница): {interval.rangecheck(interval.second)}");

        if (interval.first < interval.second)
        {
            Console.WriteLine($"  {interval.second - 1} (последнее включённое): {interval.rangecheck(interval.second - 1)}");
        }
        else
        {
            Console.WriteLine("  Интервал пустой — нет включённых значений.");
        }
    }
}
