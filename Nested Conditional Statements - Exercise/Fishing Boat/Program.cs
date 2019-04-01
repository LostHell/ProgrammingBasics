using System;


class Program
{
    static void Main()
    {
        double buged = double.Parse(Console.ReadLine());
        string sesson = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double money = 0;

        if (sesson == "Spring")
        {
            if (people <= 6)
            {
                money = 3000 * .90;
            }
            else if (people >= 7 && people <= 11)
            {
                money = 3000 * 0.85;
            }
            else if (people >= 12)
            {
                money = 3000 * .75;
            }
        }
        else if (sesson == "Summer")
        {
            if (people <= 6)
            {
                money = 4200 * .90;
            }
            else if (people >= 7 && people <= 11)
            {
                money = 4200 * 0.85;
            }
            else if (people >= 12)
            {
                money = 4200 * .75;
            }
        }
        else if (sesson == "Autumn")
        {
            if (people <= 6)
            {
                money = 4200 * .90;
            }
            else if (people >= 7 && people <= 11)
            {
                money = 4200 * 0.85;
            }
            else if (people >= 12)
            {
                money = 4200 * .75;
            }
        }
        else if (sesson == "Winter")
        {
            if (people <= 6)
            {
                money = 2600 * .90;
            }
            else if (people >= 7 && people <= 11)
            {
                money = 2600 * 0.85;
            }
            else if (people >= 12)
            {
                money = 2600 * .75;
            }
        }
        if (sesson != "Autumn" && people % 2 == 0)
        {
            money *= 0.95;
        }
        if (buged >= money)
        {
            Console.WriteLine($"Yes! You have {(buged - money):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {(money - buged):F2} leva.");
        }
    }
}