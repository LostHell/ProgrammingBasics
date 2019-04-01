using System;


class Program
{
    static void Main()
    {

        double rekord = double.Parse(Console.ReadLine());
        double razstoqnie = double.Parse(Console.ReadLine());
        double vremeZaPluvane1M = double.Parse(Console.ReadLine());

        double rezultat = (razstoqnie * vremeZaPluvane1M);
        double zabavqne = Math.Floor(razstoqnie / 15) * 12.5;
        double kraenRezultat = rezultat + zabavqne;

        if (rekord <= kraenRezultat)
        {
            Console.WriteLine($"No, he failed! He was {kraenRezultat - rekord:f2} seconds slower.");
        }
        else
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {kraenRezultat:f2} seconds.");
        }
    }
}

