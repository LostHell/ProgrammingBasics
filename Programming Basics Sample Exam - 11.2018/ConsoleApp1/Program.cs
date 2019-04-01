using System;
using System.Text;

class EqualSumsEvenOddPosition
{
    static void Main()
    {
        int moneyForFood = int.Parse(Console.ReadLine());
        int moneyForSouvenir = int.Parse(Console.ReadLine());
        int moneyForHotel = int.Parse(Console.ReadLine());

        double fuel = 54.39;
        double hotel1 = 0;
        double hotel2 = 0;
        double hotel3 = 0;

        int sum = 0;

        sum = (3 * moneyForFood) + (3 * moneyForSouvenir);
        hotel1 = moneyForHotel * 0.90;
        hotel2 = moneyForHotel * 0.85;
        hotel3 = moneyForHotel * 0.80;
        Console.WriteLine($"Money needed: {(fuel + hotel1 + hotel2 + hotel3 + sum):F2}");

    }
}