using System;
class PrimeNumber
{
    static void Main()
    {

        string input = Console.ReadLine();
        int number = 0;
        int.TryParse(input, out number);
        int primeNumber = 0;
        int notPrimeNumber = 0;

        while (input != "stop")
        {
            int.TryParse(input, out number);
            if (number < 0)
            {
                Console.WriteLine("Number is negative.");

            }
            else
            {
                if (IsPrime(number))
                {
                    primeNumber += number;
                }
                else
                {
                    notPrimeNumber += number;
                }
            }

            input = Console.ReadLine();
        }
        Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
        Console.WriteLine($"Sum of all non prime numbers is: {notPrimeNumber}");
    }
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}