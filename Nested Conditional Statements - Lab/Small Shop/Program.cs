using System;
class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quatntity = double.Parse(Console.ReadLine());

        if (town == "Sofia")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quatntity * 0.5);
            }
            else if (product == "water")
            {
                Console.WriteLine(quatntity * 0.8);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quatntity * 1.2);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quatntity * 1.45);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quatntity * 1.6);
            }
        }
        else if (town == "Plovdiv")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quatntity * 0.4);
            }
            else if (product == "water")
            {
                Console.WriteLine(quatntity * 0.7);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quatntity * 1.15);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quatntity * 1.3);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quatntity * 1.5);
            }
        }
        else if (town == "Varna")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quatntity * 0.45);
            }
            else if (product == "water")
            {
                Console.WriteLine(quatntity * 0.7);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quatntity * 1.1);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quatntity * 1.35);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quatntity * 1.55);
            }
        }

    }
}

