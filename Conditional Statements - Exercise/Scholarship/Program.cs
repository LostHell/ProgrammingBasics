using System;

class Program
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        double avgGrade = double.Parse(Console.ReadLine());
        double minSalary = double.Parse(Console.ReadLine());

        double socialScholarship = 0.0;
        double excellentScholarship = 0.0;

        if (salary < minSalary)
        {
            if (avgGrade >= 4.50 && avgGrade < 5.50)
            {
                socialScholarship = 0.35 * minSalary;
            }
            if (avgGrade >= 5.50)
            {
                excellentScholarship = 25 * avgGrade;
            }
        }
        else
        {
            if (avgGrade >= 5.50)
            {
                excellentScholarship = 25 * avgGrade;
            }
        }

        if (excellentScholarship >= socialScholarship && excellentScholarship != 0)
        {
            Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
        }
        else if (excellentScholarship < socialScholarship)
        {
            Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
        }
        else
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
    }
}

