using System;

class Histogram
{
    static void Main()
    {
        int openTab = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());


        for (int i = 0; i < openTab; i++)
        {
            string open = Console.ReadLine().ToLower();
            if (open == "facebook")
            {
                salary -= 150;
            }
            else if (open == "instagram")
            {
                salary -= 100;
            }
            else if (open == "reddit")
            {
                salary -= 50;
            }
            else
            {

            }
            if (salary == 0)
            {
                break;
            }
        }
        if (salary > 0)
        {
            Console.WriteLine(salary);
        }
        else if (salary <= 0)
        {
            Console.WriteLine("You have lost your salary.");
        }
    }
}