using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Range
{
    private int first;   
    private int second;  

    public void Read()
    {
        while (true)
        {
            Console.Write("Введите левую границу (first): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: ввод не может быть пустым. Попробуйте снова.\n");
                continue;
            }

            if (int.TryParse(input, out first))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введено не целое число. Попробуйте снова.\n");
            }
        }

        while (true)
        {
            Console.Write("Введите правую границу (second): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: ввод не может быть пустым. Попробуйте снова.\n");
                continue;
            }

            if (int.TryParse(input, out second))
            {
                if (first > second)
                {
                    Console.WriteLine($"Предупреждение: левая граница ({first}) больше правой ({second}). Интервал будет пустым.\n");
                }
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введено не целое число. Попробуйте снова.\n");
            }
        }
    }
    public void Display()
    {
        Console.WriteLine($"Интервал: [{first}, {second})");
    }

    public void rangecheck(int x)
    {
        if (x >= first && x < second)
        {
            Console.WriteLine($"Число {x} принадлежит интервалу.");
        }
        else
        {
            Console.WriteLine($"Число {x} НЕ принадлежит интервалу.");
        }
    }
}
