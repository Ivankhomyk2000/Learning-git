using System;

internal class Program
    {
        static void Main()
        {
        string separator = new string('=', 40);
        string fruitjuІce = "Strawbery juice";
        Console.WriteLine(separator);
        Console.WriteLine(fruitjuІce.Contains("w"));
        Console.WriteLine(separator);
        Console.WriteLine(fruitjuІce.IndexOf("ry"));
        Console.WriteLine(separator);
        Console.WriteLine(fruitjuІce.LastIndexOf("r"));

        bool contain = fruitjuІce.ToUpper().Contains("STRAW");
        fruitjuІce = fruitjuІce.ToLower();
        Console.WriteLine(separator);
        Console.WriteLine(fruitjuІce);
        Console.WriteLine(separator);
        Console.WriteLine(fruitjuІce.ToUpper());
        Console.WriteLine(separator);
        Console.WriteLine(contain);
        Console.WriteLine(separator);


    }
    }

