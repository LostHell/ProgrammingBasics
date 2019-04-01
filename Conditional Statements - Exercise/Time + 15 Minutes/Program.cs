using System;

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());


        minutes = minutes + 15;

        if (minutes >= 60)
        {
            minutes = minutes - 60;
            hours = hours + 1;
        }
        if (hours >= 24)
        {
            hours = hours - 24;
        }
        if (minutes < 10)
        {
            Console.WriteLine(hours + ":0" + minutes);
        }
        else
        {
            Console.WriteLine(hours + ":" + minutes);
        }


    }
}
