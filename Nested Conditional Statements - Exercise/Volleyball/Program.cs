using System;


class Program
{
    static void Main()
    {
        string sortYear = Console.ReadLine().ToLower();
        double hollydays = double.Parse(Console.ReadLine());
        double weekend = double.Parse(Console.ReadLine());
        
        double gameInSofia = 0;
        double gameInsSmallTown = 0;
        double gameInHollyday = 0;
        double addGame = 0;

        if (sortYear == "leap")
        {
            gameInSofia = ((48 - weekend) * 3) / 4;
            gameInsSmallTown = weekend;
            gameInHollyday = (hollydays * 2) / 3;
            addGame = (gameInSofia + gameInsSmallTown + gameInHollyday) * 1.15;
            Console.WriteLine(Math.Floor(addGame));
        }
        else if (sortYear == "normal")
        {
            gameInSofia = ((48 - weekend) * 3) / 4;
            gameInsSmallTown = weekend;
            gameInHollyday = (hollydays * 2) / 3;
            addGame = gameInSofia + gameInsSmallTown + gameInHollyday;
            Console.WriteLine(Math.Floor(addGame));
        }

    }
}