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
            int dni = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int torti = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int palachinki = int.Parse(Console.ReadLine());

            double rTorti = torti * 45;
            double rGofreti = gofreti * 5.80;
            double rPalachinki = palachinki * 3.20;
            double result = (rTorti + rGofreti + rPalachinki) * sladkari;
            double sumaKampania = result * dni;
            double pechalba = sumaKampania - (sumaKampania / 8);
            Console.WriteLine("{0:F2}", pechalba);

        }
    }
}
