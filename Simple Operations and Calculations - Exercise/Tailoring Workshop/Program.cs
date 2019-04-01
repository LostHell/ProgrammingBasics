using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izchislenie_za_shivashki_ceh
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double resultPokrivki = broi * (duljina + 2 * 0.3) * (shirina + 2 * 0.3);
            double resultKareta = broi * (duljina / 2) * (duljina / 2);
            double cenaUSD = (7 * resultPokrivki) + (9 * resultKareta);
            double cenaBGN = (7 * 1.85) * resultPokrivki + ((9 * 1.85) * resultKareta);
            Console.WriteLine($"{cenaUSD,0:F2} USD");
            Console.WriteLine($"{cenaBGN,0:F2} BGN");
        }
    }
}
