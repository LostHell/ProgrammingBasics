using System;
using System.Text;

class EqualSumsEvenOddPosition
{
    static void Main()
    {
        double shirina = double.Parse(Console.ReadLine());
        double duljina = double.Parse(Console.ReadLine());
        double visochina = double.Parse(Console.ReadLine());
        double visochinaAstronavti = double.Parse(Console.ReadLine());

        double obem = 0;
        double obemStaq = 0;
        double astronavti = 0;

        obem = shirina * duljina * visochina;
        obemStaq = (visochinaAstronavti + 0.40) * 2 * 2;
        astronavti = Math.Floor(obem / obemStaq);

        if (astronavti < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else if (astronavti > 10)
        {
            Console.WriteLine("The spacecraft is too big.");
        }
        else
        {
            Console.WriteLine($"The spacecraft holds {astronavti} astronauts.");
        }
    }
}