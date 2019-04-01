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
            double duljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double strana = double.Parse(Console.ReadLine());
            double result = (duljina * 100) * (shirina * 100);
            double garderob = (strana * 100) * (strana * 100);
            double peika = result / 10;
            double freespace = result - garderob - peika;
            double brTanciori = freespace / (40 + 7000);
            Console.WriteLine(Math.Floor(brTanciori));
        }
    }
}
