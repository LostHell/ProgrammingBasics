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
            double uiskicena = double.Parse(Console.ReadLine());
            double bira = double.Parse(Console.ReadLine());
            double vino = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double uiski = double.Parse(Console.ReadLine());


            double cenaRakia = uiskicena / 2;
            double cenaBira = cenaRakia - (0.8 * cenaRakia);
            double cenaVino = cenaRakia - (0.4 * cenaRakia);
            double brUiski = uiski * uiskicena;

            double kol1 = bira * cenaBira;
            double kol2 = vino * cenaVino;
            double kol3 = rakia * cenaRakia;
            double kol4 = brUiski;


            double obshto = kol1 + kol2 + kol3 + kol4;
            Console.WriteLine("{0:F2}", obshto);

        }
    }
}
