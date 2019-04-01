using System;
class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        if ((input >= 100 && input <= 200) || input == 0)
        {

        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}