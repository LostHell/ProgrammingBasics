using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int current = 1; current <= n; current += 3)
        {
            Console.WriteLine(current);
        }

    }
}