using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        int floors = int.Parse(Console.ReadLine());
        int room = int.Parse(Console.ReadLine());

        for (int i = floors; i >= 1; i--)
        {
            for (int j = 0; j < room; j++)
            {
                if (i == floors)
                {
                    Console.Write($"L{i}{j} ");
                }
                else if (i < floors && i % 2 != 0)
                {
                    Console.Write($"A{i}{j} ");
                }
                else
                {
                    Console.Write($"O{i}{j} ");
                }

            }
            Console.WriteLine();
        }
    }
}