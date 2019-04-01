using System;


class Program
{
    static void Main()
    {
        string sort = Console.ReadLine().ToLower();
        int redove = int.Parse(Console.ReadLine());
        int koloni = int.Parse(Console.ReadLine());

        double money = 0;

        if (sort == "premiere")
        {
            money = redove * koloni * 12.00;
        }
        else if (sort == "normal")
        {
            money = redove * koloni * 7.50;
        }
        else if (sort == "discount")
        {
            money = redove * koloni * 5.00;
        }
        else
        {

        }
        Console.WriteLine($"{money:F2}");
    }
}