using System;


class Program
{
    static void Main()
    {

        int count = int.Parse(Console.ReadLine());

        int currentCount = 1;
        double sum = 0;

        while (currentCount <= count)
        {
            double currentNum = double.Parse(Console.ReadLine());
            if (currentNum < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            sum += currentNum;
            Console.WriteLine($"Increase: {currentNum:F2}");
            currentCount++;

        }
        Console.WriteLine($"Total: {sum:F2}");
    }
}

