﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaRabota_9._11._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            double USD = double.Parse(Console.ReadLine());
            double BGN = 1.79549;
            double result = USD * BGN;
            Console.WriteLine("{0:F2}", result);

        }
    }
}
