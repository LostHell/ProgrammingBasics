using System;


class Program
{
    static void Main()
    {

        int birthdayLili = int.Parse(Console.ReadLine());

        int even = 0;
        int odd = 0;
        int ageMoney = 0;
        for (int age = 1; age <= birthdayLili; age++)
        {

            if (age % 2 == 0)
            {
                ageMoney++;
                even += ageMoney * 10;
            }
            else if (age % 2 == 1)
            {
                odd += 1;
            }
        }
        double washmaschin = double.Parse(Console.ReadLine());
        double priceToy = double.Parse(Console.ReadLine());
        double totalMoneyToy = odd * priceToy;
        double totalMoney = totalMoneyToy + even - ageMoney;

        if (washmaschin <= totalMoney)
        {
            Console.WriteLine($"Yes! {(totalMoney - washmaschin):F2}");
        }
        else
        {
            Console.WriteLine($"No! {(washmaschin - totalMoney):F2}");
        }

    }

}