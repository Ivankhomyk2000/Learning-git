using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Entry\n 1.Login\n 2.Registration");
        
        string autufication = Console.ReadLine();
        string adminLogin = "WOLFETCH";
        if (autufication == "1")
        {
            Console.WriteLine("Enter Login");
            string tempUsernamelogin = Console.ReadLine();
            
            
            if (tempUsernamelogin == adminLogin)
            {

                Console.WriteLine("Enter password");
                string passwordAdmin = Console.ReadLine();
                if (passwordAdmin == "140665bI")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HELLO ADMIN WOLFETCH, How can I help you?");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong password");
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The login is not registered");
                Console.ResetColor();
                System.Environment.Exit(0);
            }

        }
        
        if (autufication == "2")
        {
            Console.WriteLine("Registration");
            Console.WriteLine("Username must include 6 and more letter, but less 13");
            Console.WriteLine("Username:");
            string tempUsername = Console.ReadLine();            
            
            string username = string.Empty;
            string password = string.Empty;

            if (tempUsername == adminLogin)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("this  login is already inuse");
                Console.ResetColor();
                System.Environment.Exit(0);
            }


            if (tempUsername.Length >= 6 && tempUsername.Length <= 13 && tempUsername != adminLogin)
            {

                
                username = tempUsername;
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(username);
                Console.ResetColor();
            }

             

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username default");
                Console.ResetColor();
                System.Environment.Exit(0);
            if (tempUsername.Length <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Username is short");
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }
            if (tempUsername.Length >= 13)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Username is long");
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

            }
            Console.WriteLine("Password must include (8 digits, one lowercase letter, one uppercase letter) ");
            Console.WriteLine("Password:");
            string tempPassword = Console.ReadLine();

            if (tempPassword.Length >= 8 && tempPassword.Any(l => char.IsUpper(l))

                && tempPassword.All(l => char.IsLetter(l) || char.IsNumber(l))
                && tempPassword.Any(l => char.IsLower(l)))
            {
                password = tempPassword;
                Console.ForegroundColor = ConsoleColor.Green;
                string sep = new string('*', password.Length);
                Console.WriteLine(sep);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User password default,Please enter the correct password " +
                    "(8 digits, one lowercase letter, one uppercase letter)");
                Console.ResetColor();
                System.Environment.Exit(0);

            }
        }

    }
}
            
