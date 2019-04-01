using System;
using System.Linq;

namespace Enes_Test_2ra_Lekcia
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double cubic = height * length * width;
            double liter = cubic * 0.001;
            double procent = double.Parse(Console.ReadLine()) * 0.01;
            Console.WriteLine(Math.Round(liter * (1 - procent), 3));

        }
    }
}
