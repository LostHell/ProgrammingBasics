using System;


class Program
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int numberToShow = 1;

        while (numberToShow <= number)
        {
            Console.WriteLine(numberToShow);
            numberToShow = numberToShow * 2 + 1;
        }

    }
}