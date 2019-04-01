using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string name = string.Empty;
        int score = int.MinValue;
        while (input != "STOP")
        {
            int currentScore = 0;
            string currentName = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                currentScore += (input)[i];
                currentName += input[i];
            }
            if (currentScore > score)
            {
                score = currentScore;
                name = currentName;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Winner is {name} - {score}!");
    }
}