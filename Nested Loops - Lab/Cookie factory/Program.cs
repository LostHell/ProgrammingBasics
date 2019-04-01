using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        int batch = int.Parse(Console.ReadLine());

        for (int currentBatch = 1; currentBatch <= batch; currentBatch++)
        {
            bool flour = false;
            bool eggs = false;
            bool sugar = false;

            string product = Console.ReadLine().ToLower();
            while (true)
            {
                if (product == "flour")
                {
                    flour = true;
                }
                else if (product == "eggs")
                {
                    eggs = true;
                }
                else if (product == "sugar")
                {
                    sugar = true;
                }
                if (product == "bake!")
                {
                    if (sugar == true && eggs == true && flour == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }
                }

                product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Baking batch number {currentBatch}...");
        }
    }
}