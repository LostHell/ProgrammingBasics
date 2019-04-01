using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());

            double firstNum = 0;
            double secNum = 0;
            double threeNum = 0;
            double result = 0;
            firstNum = num % 10;
            num = (num - firstNum) / 10;
            secNum = num % 10;
            num = (num - secNum) / 10;
            threeNum = num;

            for (int i = 1; i <= firstNum; i++)
            {
                for (int j = 1; j <= secNum; j++)
                {
                    for (int k = 1; k <= threeNum; k++)
                    {
                        result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
