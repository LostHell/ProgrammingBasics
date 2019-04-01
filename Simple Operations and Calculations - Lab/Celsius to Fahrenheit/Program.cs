using System;
using System.Linq;

namespace Enes_Test_2ra_Lekcia
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsium = double.Parse(Console.ReadLine());
            double result = (celsium * 1.8000 + 32);
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
