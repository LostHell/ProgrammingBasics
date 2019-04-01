using System;
using System.Text;

class EqualSumsEvenOddPosition
{
    static void Main()
    {

        int people = int.Parse(Console.ReadLine());
        int stops = int.Parse(Console.ReadLine());

        int sumPeople = people;

        for (int i = 1; i <= stops; i++)
        {
            int peopleOut = int.Parse(Console.ReadLine());
            int peopleIn = int.Parse(Console.ReadLine());
            sumPeople = sumPeople - peopleOut + peopleIn;
            if (i % 2 == 1)
            {
                sumPeople += 2;
            }
            if (i % 2 == 0)
            {
                sumPeople -= 2;
            }

        }
        Console.WriteLine($"The final number of passengers is : {sumPeople}");
    }
}