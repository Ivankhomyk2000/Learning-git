using System;
using System.Runtime.Serialization;

internal class Program
{
    static void Main()
    {
        /*double[] temperatures = new double[5];

        temperatures[0] = 36.6;
        temperatures[1] = 37.0;

        Random rng = new Random();

        double minRange = 35.0;
        double maxRange = 40.0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = minRange +(maxRange - minRange) * rng.NextDouble();
        }
        */



        String[] bevarages = { "cola", "sprite", "fanta", "bud" };
        for (int i = 0; i < bevarages.Length; i++)
        {
            Console.WriteLine($" {bevarages[i]}");
        }
        Console.WriteLine(new string('-', 40));

        foreach (string bevarage in bevarages)
        {
            Console.WriteLine(bevarage);
        }
        Console.WriteLine(string.Join(" ", bevarages));


        Random rng = new Random();
        int[] temperatures = new int[40];
        int[] lowTemps = new int[temperatures.Length];
        int[] mediumTemps = new int[temperatures.Length];
        int[] highTemps = new int[temperatures.Length];
        int[] outOfRange = new int[temperatures.Length];

        int  lowTempsindex = 0;
        int highTempsindex = 0;
        int mediumTempsindex = 0;
        int outOfRangeindex = 0;



        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rng.Next(0, 40);
        }

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] >= 1 && temperatures[i] <= 10)
            {
                lowTemps[lowTempsindex] = temperatures[i];
                lowTempsindex++;
            }
            else if (temperatures[i] >= 11 && temperatures[i] <= 20)
            {
                mediumTemps[mediumTempsindex] = temperatures[i];
                mediumTempsindex++;
            }
            else if (temperatures[i] >= 21 && temperatures[i] <= 30)
            {
                highTemps[highTempsindex] = temperatures[i];
                highTempsindex++;
            }

            else
            {
                outOfRange[outOfRangeindex] = temperatures[i];
                outOfRangeindex++;
            }
        }
        Console.ReadKey();

        
    }
}

