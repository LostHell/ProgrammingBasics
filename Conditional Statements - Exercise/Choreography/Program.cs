using System;


class Program
{
    static void Main()
    {

        double stupki = double.Parse(Console.ReadLine());
        double tanciori = double.Parse(Console.ReadLine());
        double dni = double.Parse(Console.ReadLine());

        double razpredelenie = ((stupki / dni) / stupki) * 100;
        double rezultat = Math.Ceiling(razpredelenie) / tanciori;

        if (razpredelenie <= 13)
        {
            Console.WriteLine($"Yes, they will succeed in that goal! {rezultat:F2}%.");
        }
        else
        {
            Console.WriteLine($"No, They will not succeed in that goal! Required {rezultat:F2}% steps to be learned per day.");
        }

    }
}

