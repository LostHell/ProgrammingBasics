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
        int result = 0;

        for (int number1 = 0; number1 <= n; number1++)
        {
            for (int number2 = 0; number2 <= n; number2++)
            {
                for (int number3 = 0; number3 <= n; number3++)
                {
                    for (int number4 = 0; number4 <= n; number4++)
                    {
                        for (int number5 = 0; number5 <= n; number5++)
                        {
                            int resultNumber = number1 + number2 + number3 + number4 + number5;

                            if (resultNumber == n)
                            {
                                result++;
                            }

                        }
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}