using System;


class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string sesson = Console.ReadLine().ToLower();

        double leftMoney = 0;

        if (money <= 100)
        {
            if (sesson == "summer")
            {
                leftMoney = money * 0.30;
                Console.WriteLine($"Somewhere in Bulgaria");
                Console.WriteLine($" Camp - {leftMoney:F2}");
            }
            else if (sesson == "winter")
            {
                leftMoney = money * 0.70;
                Console.WriteLine($"Somewhere in Bulgaria");
                Console.WriteLine($"Hotel - {leftMoney:F2}");
            }
        }
        else if (money > 100 && money <= 1000)
        {
            if (sesson == "summer")
            {
                leftMoney = money * 0.40;
                Console.WriteLine($"Somewhere in Balkans");
                Console.WriteLine($"Camp - {leftMoney:F2}");
            }
            else if (sesson == "winter")
            {
                leftMoney = money * 0.80;
                Console.WriteLine($"Somewhere in Balkans");
                Console.WriteLine($"Hotel - {leftMoney:F2}");
            }
        }
        else if (money > 1000)
        {
            leftMoney = money * 0.90;
            Console.WriteLine($"Somewhere in Europe");
            Console.WriteLine($"Hotel - {leftMoney:F2}");
        }

    }
}