using System;

class Program
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double bonus = 0;

        if (num % 2 == 0)
        {
            bonus += 1;
        }

        if (num % 10 == 5)
        {
            bonus += 2;
        }

        if (num <= 100)
        {
            bonus += +5;
        }
        else if (num > 100 && num <= 1000)
        {
            bonus += num * 0.20;
        }
        else if (num > 1000)
        {
            bonus += num * 0.10;
        }

        num += bonus;

        Console.WriteLine(bonus);
        Console.WriteLine(num);

    }
}
