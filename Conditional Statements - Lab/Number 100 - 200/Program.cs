using System;
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

            if (a < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (a >= 100 && a <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (a > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}