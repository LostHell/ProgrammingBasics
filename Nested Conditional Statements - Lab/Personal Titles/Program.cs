﻿using System;
class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (gender == "f")
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
        else if (gender == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr.");
            }
        }
        else
        {

        }


    }
}

