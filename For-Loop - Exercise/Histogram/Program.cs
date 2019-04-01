using System;

class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double to200 = 0;
        double to400 = 0;
        double to600 = 0;
        double to800 = 0;
        double to1000 = 0;
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;


        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 200)
            {
                to200++;
            }
            else if (number >= 200 && number < 400)
            {
                to400++;
            }
            else if (number >= 400 && number < 600)
            {
                to600++;
            }
            else if (number >= 600 && number < 800)
            {
                to800++;
            }
            else if (number >= 800)
            {
                to1000++;
            }

        }
        if (to200 != 0)
        {
            p1 = (to200 / n) * 100;
        }
        if (to400 != 0)
        {
            p2 = (to400 / n) * 100;
        }
        if (to600 != 0)
        {
            p3 = (to600 / n) * 100;
        }
        if (to800 != 0)
        {
            p4 = (to800 / n) * 100;
        }
        if (to1000 != 0)
        {
            p5 = (to1000 / n) * 100;
        }


        Console.WriteLine($"{p1:F2}%");
        Console.WriteLine($"{p2:F2}%");
        Console.WriteLine($"{p3:F2}%");
        Console.WriteLine($"{p4:F2}%");
        Console.WriteLine($"{p5:F2}%");
    }
}