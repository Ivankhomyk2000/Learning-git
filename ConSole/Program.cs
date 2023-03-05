using System;


internal class Program
    {
    static void Main()
    {
        Console.Title = "UKRAINE";
        ///Console.SetCursorPosition(0, 0);
        Console.CursorLeft = 20;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Red;
        string a = "apple";
        string b = "banana";
        float fax = 5.45678f;
        Console.WriteLine("{0,15}", a);
        Console.WriteLine("{0,15}", b);
        Console.WriteLine("{0,15:C3}", fax);
        Console.WriteLine($"{a,15}");
        Console.WriteLine($"{b,15}");

        Console.WriteLine($"{fax,0:C5}");

        float z = 6.74747f;
        float x = 51.56352f;
        float y = 123.15254f;
        float v = 45.2124f;
        float n = 1245.21f;

        float cost = z + x + y + v + n;
        string protein = "Protein intake Week 1";
        string sep = new string('=', protein.Length);
        Console.WriteLine("|");
        Console.Write(protein);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(sep);
        Console.Write("|\n");

        Console.ForegroundColor = ConsoleColor.Green;
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        char keychar = key.KeyChar;
        Console.WriteLine($"The key was pressed is: {keychar}");
        Console.WriteLine($"Modifiers: {key.Modifiers}");

        Console.CursorLeft = 20;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("       =        =        =        ");
        Console.WriteLine("       =  =     =     =  =        ");
        Console.WriteLine("       =   =    =    =   =        ");
        Console.WriteLine("       =  =     =     =  =        ");
        Console.WriteLine("       =   =         =   =        ");
        Console.BackgroundColor = ConsoleColor.Yellow;
        string line = "=    =  = =  =    =";
        string line2 = new string('=', line.Length);
        //Console.WriteLine($"       {line}        ");
        //Console.WriteLine($"       {line2}        ");
        Console.WriteLine("{0,26}", line);
        Console.WriteLine("              =   =               ");
        Console.WriteLine("                =                 ");
        
       



    }
    }
