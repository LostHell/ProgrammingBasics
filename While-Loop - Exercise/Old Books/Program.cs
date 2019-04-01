using System;

class Program
{
    static void Main()
    {

        string book = Console.ReadLine();
        int memory = int.Parse(Console.ReadLine());
        string bookName = "";
        double space = 0;

        while (memory > space)
        {
            bookName = Console.ReadLine();
            if (book == bookName)
            {
                break;
            }
            space++;
        }
        if (book == bookName)
        {
            Console.WriteLine($"You checked {space} books and found it.");
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {space} books.");
        }
    }
}
