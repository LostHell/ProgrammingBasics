﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Retake_Exam___11_and_12_August_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine($"{a}");
            }
            else if (b >= a)
            {
                Console.WriteLine($"{b}");
            }
        }
    }
}