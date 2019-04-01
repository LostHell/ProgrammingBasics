using System;


class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        double result = 0;
        string evenOdd = "";

        if (symbol == "+" || symbol == "-" || symbol == "*")
        {
            if (symbol == "+")
            {
                result = num1 + num2;
            }
            else if (symbol == "-")
            {
                result = num1 - num2;
            }
            else if (symbol == "*")
            {
                result = num1 * num2;
            }
            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine(num1 + " " + symbol + " " + num2 + " = " + result + " - " + evenOdd);
        }
        else if (symbol == "/" && num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine(num1 + " " + symbol + " " + num2 + " = " + result.ToString("F2"));
        }
        else if (symbol == "/" && num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }
        else if (symbol == "%" && num2 != 0)
        {
            result = num1 % num2;
            Console.WriteLine(num1 + " " + symbol + " " + num2 + " = " + result);
        }
        else if (symbol == "%" && num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }



    }
}