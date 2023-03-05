using System;
    internal class Program
    {
    static void Main()
    {

        string a = Console.ReadLine();
        if (a.ToString()[a.ToString().Length - 3] == '3')
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        }
    }

