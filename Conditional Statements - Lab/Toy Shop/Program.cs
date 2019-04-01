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
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());


            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;


            double money = puzzel * puzzlePrice + doll * dollPrice + bear * bearPrice + minion * minionPrice + truck * truckPrice;
            int amountToys = puzzel + doll + bear + minion + truck;


            if (amountToys >= 50)
            {
                money = money * 0.75;
            }

            money = money * 0.90;

            double diff = money - travelPrice;

            if (diff < 0)
            {
                Console.WriteLine($"Not enough money! {Math.Abs(diff):F2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {Math.Abs(diff):F2} lv left.");
            }
        }
    }
}