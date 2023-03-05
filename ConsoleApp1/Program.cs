using System;
using System.Threading;

internal class Program
    {
        static void Main(string[] args)
        {
        int number = 0;
        int min = 20;
        int max = 30;
        bool numberInRange = false;
        int exit = 0;
        int attempt = 3;

        while (!numberInRange)
        {
            Console.WriteLine($"Input values in the range {min} to {max} ");
            Console.WriteLine($"You have {attempt} attempt");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= min && number <= max)
            {
                numberInRange = true;
            }
            else
            {
                Console.WriteLine("Please input another number.");
                exit++;
                Thread.Sleep(500);
                Console.Clear();
                attempt--;
                

            }
            if (exit >= 3)
            {
                Console.WriteLine("INPUT WRONG");
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
                System.Environment.Exit(0);
            }
            
        }
    }
    }

