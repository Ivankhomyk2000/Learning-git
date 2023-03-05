using System;


internal class Program
{
    static void Main()
    {
        Console.WriteLine(Perimeter(5, 6, 7, 8, 5, 4, 3, 2, 1));

        Console.ReadKey();

    }
    static int Perimeter(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }
}

