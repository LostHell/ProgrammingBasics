using System;


class Program
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        double sleep = double.Parse(Console.ReadLine());

        double apartment = 0;
        double studio = 0;



        if (month == "may" || month == "october")
        {
            if (sleep <= 7)
            {
                studio = 50 * sleep;
                apartment = 65 * sleep;
            }
            else if (sleep > 7 && sleep <= 14)
            {
                studio = (50 * sleep) * 0.95;
                apartment = 65 * sleep;
            }
            else if (sleep > 14)
            {
                studio = (50 * sleep) * 0.70;
                apartment = (65 * sleep) * 0.90;
            }
        }
        else if (month == "june" || month == "september")
        {
            if (sleep <= 14)
            {
                studio = 75.20 * sleep;
                apartment = 68.20 * sleep;
            }
            else if (sleep > 14)
            {
                studio = (75.20 * sleep) * 0.80;
                apartment = (68.70 * sleep) * 0.90;
            }
        }
        else if (month == "july" || month == "august")
        {

            if (sleep > 14)
            {
                studio = 76.00 * sleep;
                apartment = (77.00 * sleep) * 0.90;
            }
            else if (sleep <= 14)
            {
                studio = 76.00 * sleep;
                apartment = 77.00 * sleep;
            }

        }
        Console.WriteLine($"Apartment: {apartment:F2} lv.");
        Console.WriteLine($"Studio: {studio:F2} lv.");


    }
}