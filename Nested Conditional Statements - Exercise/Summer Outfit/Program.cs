using System;


class Program
{
    static void Main()
    {
        int celsium = int.Parse(Console.ReadLine());
        string time = Console.ReadLine().ToLower();

        string outfit = "";
        string shoes = "";

        if (celsium >= 10 && celsium <= 18)
        {
            if (time == "morning")
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (time == "afternoon")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (time == "evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        else if (celsium > 18 && celsium <= 24)
        {
            if (time == "morning")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (time == "afternoon")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (time == "evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        else if (celsium >= 25)
        {
            if (time == "morning")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (time == "afternoon")
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else if (time == "evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

        }
        Console.WriteLine($"It's {celsium} degrees, get your {outfit} and {shoes}.");
    }
}