using System;

internal class EntryPoint
    {
        static void Main()
        {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char theCharacter = 'x';
        Console.WriteLine(theCharacter);
        
        char plusing = '\u00C6';

        Console.WriteLine(plusing);
       
        }
    }

