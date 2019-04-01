using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int allmax = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            allmax += num;
        }
        int all = allmax - max;
        if (all == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + max);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(max - all)}");
        }
    }
}