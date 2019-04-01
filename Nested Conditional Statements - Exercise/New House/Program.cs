using System;


class Program
{
    static void Main()
    {
        string flower = Console.ReadLine();
        int numberFlower = int.Parse(Console.ReadLine());
        double buged = double.Parse(Console.ReadLine());

        double money = 0;

        if (flower == "Roses")
        {
            if (numberFlower > 80)
            {
                money = 5 * 0.90 * numberFlower;
            }
            else
            {
                money = 5 * numberFlower;
            }
        }
        else if (flower == "Dahlias")
        {
            if (numberFlower > 90)
            {
                money = 3.80 * 0.85 * numberFlower;
            }
            else
            {
                money = 3.80 * numberFlower;
            }
        }
        else if (flower == "Tulips")
        {
            if (numberFlower > 80)
            {
                money = 2.80 * 0.85 * numberFlower;
            }
            else
            {
                money = 2.80 * numberFlower;
            }
        }
        else if (flower == "Narcissus")
        {
            if (numberFlower >= 120)
            {
                money = 3 * numberFlower;
            }
            else
            {
                money = 3 * 1.15 * numberFlower;
            }
        }
        else if (flower == "Gladiolus")
        {
            if (numberFlower >= 80)
            {
                money = 2.50 * numberFlower;
            }
            else
            {
                money = 2.50 * 1.20 * numberFlower;
            }
        }
        if (buged >= money)
        {
            Console.WriteLine($"Hey, you have a great garden with {numberFlower} {flower} and {(buged - money):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {(money - buged):F2} leva more.");
        }
    }
}