using System;


class Program
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());

        int even = 0;
        int odd = 0;
        for (int current = 0; current < num; current++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            if (current % 2 == 0)
            {
                even += currentNum;
            }
            else
            {
                odd += currentNum;
            }
        }
        if (even == odd)
        {
            Console.WriteLine($"Yes, sum {odd}");
        }
        else
        {
            int diff = Math.Abs(even - odd);
            Console.WriteLine($"No, diff {diff}");
        }
    }
}