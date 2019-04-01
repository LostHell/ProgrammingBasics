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

        for (int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(Math.Pow(2, i));
        }

    }
}