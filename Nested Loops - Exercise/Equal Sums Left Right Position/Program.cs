using System;

class EqualSumsEvenOddPosition
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int sec = int.Parse(Console.ReadLine());
        int current;
        int left = 0;
        int right = 0;

        if (first >= 10000 && sec <= 99999)
        {
            for (int i = first; i <= sec; i++)
            {
                current = i;

                int fiveDigit = current % 10;
                current = (current - fiveDigit) / 10;

                int fourDigit = current % 10;
                current = (current - fourDigit) / 10;

                int threeDigit = current % 10;
                current = (current - threeDigit) / 10;

                int secDigit = current % 10;
                current = (current - secDigit) / 10;

                int firsDigit = current % 10;
                current = (current - firsDigit) / 10;

                left = firsDigit + secDigit;
                right = fourDigit + fiveDigit;

                if (left > right)
                {
                    right += threeDigit;
                }
                else if (left < right)
                {
                    left += threeDigit;
                }
                if (left == right)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}