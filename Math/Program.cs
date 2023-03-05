using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        string userName = "prett";


        bool flagCapitalLeters = userName.Length < 6 || (int)userName[0] >= 65 && (int)userName[0] <= 90;
        Console.WriteLine(flagCapitalLeters);

        string incomingUsername = "prettyboy";
        string ia = "hello";
        string userNamecoming = incomingUsername.Length < 10 ? ia : "default";
        Console.WriteLine(userNamecoming);
        }
    }

