using System;
using System.Text;

class EqualSumsEvenOddPosition
{
    static void Main()
    {

        string sortSushi = Console.ReadLine();
        string restaurant = Console.ReadLine();
        int pcs = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        double price = 0;

        if (restaurant == "Sushi Zone")
        {
            if (sortSushi == "sashimi")
            {
                price = pcs * 4.99;
            }
            else if (sortSushi == "maki")
            {
                price = pcs * 5.29;
            }
            else if (sortSushi == "uramaki")
            {
                price = pcs * 5.99;
            }
            else if (sortSushi == "temaki")
            {
                price = pcs * 4.29;
            }
        }
        else if (restaurant == "Sushi Time")
        {
            if (sortSushi == "sashimi")
            {
                price = pcs * 5.49;
            }
            else if (sortSushi == "maki")
            {
                price = pcs * 4.69;
            }
            else if (sortSushi == "uramaki")
            {
                price = pcs * 4.49;
            }
            else if (sortSushi == "temaki")
            {
                price = pcs * 5.19;
            }
        }
        else if (restaurant == "Sushi Bar")
        {
            if (sortSushi == "sashimi")
            {
                price = pcs * 5.25;
            }
            else if (sortSushi == "maki")
            {
                price = pcs * 5.55;
            }
            else if (sortSushi == "uramaki")
            {
                price = pcs * 6.25;
            }
            else if (sortSushi == "temaki")
            {
                price = pcs * 4.75;
            }
        }
        else if (restaurant == "Asian Pub")
        {
            if (sortSushi == "sashimi")
            {
                price = pcs * 4.50;
            }
            else if (sortSushi == "maki")
            {
                price = pcs * 4.80;
            }
            else if (sortSushi == "uramaki")
            {
                price = pcs * 5.50;
            }
            else if (sortSushi == "temaki")
            {
                price = pcs * 5.50;
            }
        }
        else
        {
            Console.WriteLine($"{restaurant} is invalid restaurant!");
            return;
        }
        if (symbol == "Y")
        {
            price = price + (price * 0.20);
            Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
        }
        else if (symbol == "N")
        {
            Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
        }

    }
}