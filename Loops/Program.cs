using System;
internal class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int min = 20;
        int max = 30;
        bool numberInRange = false;

        while (!numberInRange)
        {
            Console.WriteLine($"Input values in the range {min} to {max} ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= min && number <= max)
            {
                numberInRange = true;
            }
            else
            {
                Console.WriteLine("Please input another number.");
            }
        }

    }
}

