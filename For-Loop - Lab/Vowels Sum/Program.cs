using System;


class Program
{
    static void Main()
    {

        string text = Console.ReadLine();

        int sum = 0;

        for (int letterIndex = 0; letterIndex < text.Length; letterIndex++)
        {
            char letter = text[letterIndex];
            switch (letter)
            {
                case 'a': sum += 1; break;
                case 'e': sum += 2; break;
                case 'i': sum += 3; break;
                case 'o': sum += 4; break;
                case 'u': sum += 5; break;
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }
}