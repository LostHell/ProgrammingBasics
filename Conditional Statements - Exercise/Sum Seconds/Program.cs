using System;

class Program
{
    static void Main()
    {
        int fNum = int.Parse(Console.ReadLine());
        int sNum = int.Parse(Console.ReadLine());
        int tNum = int.Parse(Console.ReadLine());

        int finalNum = fNum + sNum + tNum;

        int minutes = finalNum / 60;
        int seconds = finalNum % 60;

        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}
