using System;

internal class Program
    {
        static void Main()
        {
        int a = 11;
        int intMax = int.MaxValue;
        int intMin = int.MinValue;

        Console.WriteLine(intMin);
        Console.WriteLine(intMax);

        uint somein = 5;
        uint minUint = uint.MinValue;
        uint someuint = uint.MaxValue;

        Console.WriteLine(minUint);
        Console.WriteLine(someuint);
        Console.WriteLine(Math.Pow(2, 32));

        }
    }
