using System;

    internal class Program
    {
        static void Main()
        {
        Random rng = new Random();
        int[] intArray = new int[10];
         for (int i = 0; i < intArray.Length; i++)
        {
           if(i % 2 == 0)
            {
                Console.WriteLine($"Current Index {i}, current element is {intArray[i]}");
            }
            
        }
        }
    }

