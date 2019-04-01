using System;

class Program
{
    static void Main()
    {

        int shirina = int.Parse(Console.ReadLine());
        int duljina = int.Parse(Console.ReadLine());

        int allPieces = shirina * duljina;

        while (allPieces >= 0)
        {
            string command = Console.ReadLine();
            if (command == "STOP")
            {
                Console.WriteLine($"{allPieces} pieces are left.");
                break;
            }
            int eatPieces = int.Parse(command);
            allPieces = allPieces - eatPieces;
            if (allPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
                break;
            }
        }
    }
}