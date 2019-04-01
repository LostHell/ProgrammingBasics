using System;


class Program
{
    static void Main()
    {

        int halfNumberCount = int.Parse(Console.ReadLine());

        int firstNSsum = 0;
        int secNSum = 0;

        for (int i = 0; i < 2 * halfNumberCount; i++)
        {

            int number = int.Parse(Console.ReadLine());
            if (i < halfNumberCount)
            {
                firstNSsum += number;
            }
            else
            {
                secNSum += number;
            }
        }
        if (firstNSsum == secNSum)
        {
            Console.WriteLine($"Yes, sum {firstNSsum}");
        }
        else
        {
            int diff = Math.Abs(firstNSsum - secNSum);
            Console.WriteLine($"No, diff {diff}");
        }
    }
}