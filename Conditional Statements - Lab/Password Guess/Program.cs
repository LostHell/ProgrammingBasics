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
            string a = Console.ReadLine();

            if (a == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
