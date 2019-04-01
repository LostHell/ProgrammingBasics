using System;


class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        double grade = double.Parse(Console.ReadLine());
        int currentClass = 1;
        double allGrades = 0;

        while (currentClass <= 12)
        {
            if (grade >= 4.00)
            {
                allGrades += grade;
                currentClass++;
            }
            if (currentClass <= 12)
            {
                grade = double.Parse(Console.ReadLine());
            }

        }
        double average = allGrades / 12;
        Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
    }
}

