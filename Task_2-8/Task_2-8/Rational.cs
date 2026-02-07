using System;

class Rational
{
    private int first;
    private int second;

    private int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private void Reduce()
    {
        if (first == 0)
        {
            second = 1;
            return;
        }

        if (second < 0)
        {
            first = -first;
            second = -second;
        }

        int gcd = GCD(first, second);
        first /= gcd;
        second /= gcd;
    }

    public void Read()
    {
        while (true)
        {
            Console.WriteLine("Введите числитель: ");
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
            Console.WriteLine("Введите знаменатель (не равен 0): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: ввод не может быть пустым. Попробуйте снова.\n");
                continue;
            }

            if (int.TryParse(input, out second))
            {
                if (second == 0)
                {
                    Console.WriteLine("Ошибка: знаменатель не может быть равен нулю. Попробуйте снова.\n");
                    continue;
                }
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введено не целое число. Попробуйте снова.\n");
            }
        }

        Reduce();
    }

    public void Display()
    {
        if (first == 0)
        {
            Console.Write("0");
        }
        else if (second == 1)
        {
            Console.Write(first);
        }
        else
        {
            Console.Write($"{first}/{second}");
        }
    }
    public Rational Add(Rational other)
    {
        int newFirst = first * other.second + other.first * second;
        int newSecond = second * other.second;
        Rational result = new Rational();
        result.first = newFirst;
        result.second = newSecond;
        result.Reduce();
        return result;
    }

    public Rational Subtract(Rational other)
    {
        int newFirst = first * other.second - other.first * second;
        int newSecond = second * other.second;
        Rational result = new Rational();
        result.first = newFirst;
        result.second = newSecond;
        result.Reduce();
        return result;
    }

    public Rational Multiply(Rational other)
    {
        int newFirst = first * other.first;
        int newSecond = second * other.second;
        Rational result = new Rational();
        result.first = newFirst;
        result.second = newSecond;
        result.Reduce();
        return result;
    }

    public Rational Divide(Rational other)
    {
        if (other.first == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
            return null;
        }

        int newFirst = first * other.second;
        int newSecond = second * other.first;
        Rational result = new Rational();
        result.first = newFirst;
        result.second = newSecond;
        result.Reduce();
        return result;
    }

    public int CompareTo(Rational other)
    {
        long left = (long)first * other.second;
        long right = (long)other.first * second;

        if (left < right) return -1;
        if (left > right) return 1;
        return 0;
    }

}