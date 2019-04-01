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
            string figur = Console.ReadLine();


            if (figur == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (figur == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleSideA * rectangleSideB;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (figur == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"{circleArea:F3}");
            }
            else if (figur == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double triangleArea = (triangleSide * height) / 2;
                Console.WriteLine($"{triangleArea:F3}");
            }
        }
    }
}