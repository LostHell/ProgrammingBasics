using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range [1...100]: ");
        int a = int.Parse(Console.ReadLine());

        while (a < 1 || a > 100)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a number in the range [1...100]: ");
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number is: " + a);


    }
}

