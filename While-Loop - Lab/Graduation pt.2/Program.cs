using System;


class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        double grade;

        int currentClass = 0;
        double totalGrades = 0;

        int warnings = 0;

        while (currentClass < 12)
        {
            grade = double.Parse(Console.ReadLine());
            if (grade < 4)
            {
                warnings++;
            }
            if (warnings == 2)
            {
                break;
            }
            currentClass++;
            totalGrades += grade;

        }

        double avgGrade = totalGrades / 12;

        if (warnings == 2)
        {
            Console.WriteLine(name + " has been excluded at " + currentClass + " grade");
        }
        else
        {
            Console.WriteLine(name + " graduated. Average grade: " + avgGrade.ToString("F2"));
        }
    }
}