using System;

    internal class Program
    {
        static void Main()
        {
        
        string convertTo = Console.ReadLine();
        switch (convertTo)
        {
            case "km":
                Console.WriteLine($"You have chossen kilometers");
                break;

            case "dm":
                Console.WriteLine($"You have chossen desimeter");
                break;

        }
        }
    }

