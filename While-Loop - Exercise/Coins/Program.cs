using System;

class Program
{
    static void Main()
    {

        double money = double.Parse(Console.ReadLine());

        double coins = 0;

        while (true)
        {



            if (money >= 3.00)
            {
                money = money - 2.00;
                coins++;
            }
            else if (money >= 2.00)
            {
                money = Math.Round(money - 2.00, 2);
                coins++;
            }
            else if (money >= 1.00)
            {
                money = Math.Round(money - 1.00, 2);
                coins++;
            }
            else if (money >= 0.50)
            {
                money = Math.Round(money - 0.50, 2);
                coins++;
            }
            else if (money >= 0.20)
            {
                money = Math.Round(money - 0.20, 2);
                coins++;
            }
            else if (money >= 0.10)
            {
                money = Math.Round(money - 0.10, 2);
                coins++;
            }
            else if (money >= 0.05)
            {
                money = Math.Round(money - 0.05, 2);
                coins++;
            }
            else if (money >= 0.02)
            {
                money = Math.Round(money - 0.02, 2);
                coins++;
            }
            else if (money == 0.01)
            {
                coins++;
                money = money - 0.01;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(coins);

    }
}