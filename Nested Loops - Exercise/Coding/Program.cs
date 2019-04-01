using System;
class PrimeNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string numAsStr = number.ToString();
        int strLength = numAsStr.Length;
        for (int i = 1; i <= strLength; i++)
        {
            int lastDigit = number % 10; //9
            number -= lastDigit;
            number /= 10;
            if (lastDigit == 0)
            {
                Console.WriteLine("ZERO");
            }
            else if (lastDigit != 0)
            {
                char name = Convert.ToChar(lastDigit + 33);
                Console.WriteLine(new string(name, lastDigit));
            }

        }
        //for
        //Console.WriteLine(new string('*', 10));
    }
}