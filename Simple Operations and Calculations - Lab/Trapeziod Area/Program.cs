using System;
using System.Linq;

namespace Enes_Test_2ra_Lekcia
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double Area = (((b1 + b2) * h) / 2);
            Console.WriteLine(Area);
        }
    }
}
