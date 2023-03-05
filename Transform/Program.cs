using System;

internal class Program
    {
    static void Main(string[] args)
    {
        int bignumber = 546357;
        Console.WriteLine(bignumber.ToString().Contains("5"));
        Console.WriteLine(bignumber.ToString().IndexOf("5"));
        Console.WriteLine(bignumber.ToString().LastIndexOf("5"));
        string name = "Oksana ";
        string statement = "lox";
        string conect = name + statement;
        Console.WriteLine(conect.ToUpper());
        Console.WriteLine();
        Console.WriteLine($" {name} = {statement}  ");
        string a = "5";
        
        int stringa = Convert.ToInt32(a);
        int b = stringa + 10;
        Console.WriteLine($"{a} convert in {stringa} = b + a = {b}");

        int paRsed = int.Parse(a);
        Console.WriteLine(paRsed);

        }
    }

