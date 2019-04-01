using System;


class Program
{
    static void Main(string[] args)
    {

        double shirina = double.Parse(Console.ReadLine());
        double visochina = double.Parse(Console.ReadLine());
        double duljina = double.Parse(Console.ReadLine());

        double result = 0;
        double obemBagaj = 0;

        while (true)
        {
            string command = Console.ReadLine().ToLower();
            if (command == "done")
            {
                Console.WriteLine($"{result - obemBagaj} Cubic meters left.");
                break;
            }
            result = shirina * visochina * duljina;
            double obem = double.Parse(command);
            obemBagaj += obem;
            if (obemBagaj > result)
            {
                Console.WriteLine($"No more free space! You need {obemBagaj - result} Cubic meters more.");
                break;
            }
        }
    }
}