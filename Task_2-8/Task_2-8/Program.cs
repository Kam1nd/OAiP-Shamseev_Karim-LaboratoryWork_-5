class Program
{
    static void Main()
    {
        Console.WriteLine("=== Работа с рациональными дробями ===\n");

        // Ввод первой дроби
        Console.WriteLine("Первая дробь:");
        Rational r1 = new Rational();
        r1.Read();
        Console.Write("Первая дробь: ");
        r1.Display();
        Console.WriteLine("\n");

        // Ввод второй дроби
        Console.WriteLine("Вторая дробь:");
        Rational r2 = new Rational();
        r2.Read();
        Console.Write("Вторая дробь: ");
        r2.Display();
        Console.WriteLine("\n");

        // Арифметические операции
        Console.WriteLine("Результаты операций:");

        Console.Write("Сложение: ");
        r1.Display();
        Console.Write(" + ");
        r2.Display();
        Console.Write(" = ");
        r1.Add(r2).Display();
        Console.WriteLine();

        Console.Write("Вычитание: ");
        r1.Display();
        Console.Write(" - ");
        r2.Display();
        Console.Write(" = ");
        r1.Subtract(r2).Display();
        Console.WriteLine();

        Console.Write("Умножение: ");
        r1.Display();
        Console.Write(" * ");
        r2.Display();
        Console.Write(" = ");
        r1.Multiply(r2).Display();
        Console.WriteLine();

        Console.Write("Деление: ");
        r1.Display();
        Console.Write(" / ");
        r2.Display();
        Console.Write(" = ");
        Rational division = r1.Divide(r2);
        
        division.Display();
        Console.WriteLine();

        // Сравнение
        Console.Write("\nСравнение: ");
        r1.Display();
        Console.Write(" и ");
        r2.Display();
        Console.WriteLine();

        int cmp = r1.CompareTo(r2);
        if (cmp < 0)
            Console.WriteLine("Первая дробь меньше второй");
        else if (cmp > 0)
            Console.WriteLine("Первая дробь больше второй");
        else
            Console.WriteLine("Дроби равны");
    }
}
