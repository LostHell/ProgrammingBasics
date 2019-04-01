using System;

class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double to2 = 0;
        double to3 = 0;
        double to4 = 0;
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;


        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                to2++;
            }
            if (number % 3 == 0)
            {
                to3++;
            }
            if (number % 4 == 0)
            {
                to4++;
            }
        }
        if (to2 != 0)
        {
            p1 = (to2 / n) * 100;
        }
        if (to3 != 0)
        {
            p2 = (to3 / n) * 100;
        }
        if (to4 != 0)
        {
            p3 = (to4 / n) * 100;
        }


        Console.WriteLine($"{p1:F2}%");
        Console.WriteLine($"{p2:F2}%");
        Console.WriteLine($"{p3:F2}%");
    }
}