using System;

class ThreeBrothers
{
    static void Main(string[] args)
    {
        double brother1 = double.Parse(Console.ReadLine());
        double brother2 = double.Parse(Console.ReadLine());
        double brother3 = double.Parse(Console.ReadLine());
        double fishtime = double.Parse(Console.ReadLine());

        double cleaningTime = 1 / (1 / brother1 + 1 / brother2 + 1 / brother3);
        double totalTime = cleaningTime + cleaningTime * 0.15;
        double timeDifference = Math.Abs(fishtime - totalTime);
        string output = "";

        if (fishtime > totalTime)
        {
            output = string.Format("Yes, there is a surprise - time left -> {0:F0} hours.", Math.Floor(timeDifference));
        }
        else
        {
            output = string.Format("No, there isn't a surprise - shortage of time -> {0:F0} hours.", Math.Ceiling(timeDifference));
        }

        Console.WriteLine($"Cleaning time: {totalTime:F}");
        Console.WriteLine(output);
    }
}