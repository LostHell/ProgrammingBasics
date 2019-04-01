using System;
class Program
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double sell = double.Parse(Console.ReadLine());

        double comission = 0;

        if (town == "sofia")
        {
            if (sell >= 0 && sell <= 500)
            {
                comission = sell * 0.05;
            }
            else if (sell > 500 && sell <= 1000)
            {
                comission = sell * 0.07;
            }
            else if (sell > 1000 && sell <= 10000)
            {
                comission = sell * 0.08;
            }
            else if (sell > 10000)
            {
                comission = sell * 0.12;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "varna")
        {
            if (sell >= 0 && sell <= 500)
            {
                comission = sell * 0.045;
            }
            else if (sell > 500 && sell <= 1000)
            {
                comission = sell * 0.075;
            }
            else if (sell > 1000 && sell <= 10000)
            {
                comission = sell * 0.1;
            }
            else if (sell > 10000)
            {
                comission = sell * 0.13;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "plovdiv")
        {
            if (sell >= 0 && sell <= 500)
            {
                comission = sell * 0.055;
            }
            else if (sell > 500 && sell <= 1000)
            {
                comission = sell * 0.08;
            }
            else if (sell > 1000 && sell <= 10000)
            {
                comission = sell * 0.12;
            }
            else if (sell > 10000)
            {
                comission = sell * 0.145;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }

        Console.WriteLine($"{comission}:F2");
    }
}