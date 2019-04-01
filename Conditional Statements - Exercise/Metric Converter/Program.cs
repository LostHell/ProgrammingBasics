using System;

class Program
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        double mm = 1000;
        double cm = 100;
        double m = 1;
        double mi = 0.000621371192;
        double inches = 39.3700787;
        double km = 0.001;
        double ft = 3.2808399;
        double yd = 1.0936133;

        if (input == "mm")
        {
            num = num / mm;
        }
        else if (input == "cm")
        {
            num = num / cm;
        }
        else if (input == "m")
        {
            num = num * m;
        }
        else if (input == "mi")
        {
            num = num / mi;
        }
        else if (input == "in")
        {
            num = num / inches;
        }
        else if (input == "km")
        {
            num = num / km;
        }
        else if (input == "ft")
        {
            num = num / ft;
        }
        else if (input == "yd")
        {
            num = num / yd;
        }

        if (output == "mm")
        {
            num = num * mm;
        }
        else if (output == "cm")
        {
            num = num * cm;
        }
        else if (output == "m")
        {
            num = num * m;
        }
        else if (output == "mi")
        {
            num = num * mi;
        }
        else if (output == "in")
        {
            num = num * inches;
        }
        else if (output == "km")
        {
            num = num * km;
        }
        else if (output == "ft")
        {
            num = num * ft;
        }
        else if (output == "yd")
        {
            num = num * yd;
        }

        Console.WriteLine($"{num:F8}");
    }
}
