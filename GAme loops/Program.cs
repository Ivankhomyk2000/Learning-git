using System;
    internal class Program
    {
    static void Main()
    {
        Random rng = new Random();
        Random rngMag = new Random(); 
        Random rngWarrior = new Random();
        string warriorName = "Bob";
        string mageName = "Carl";
        int warriorDamage = 0;
        int mageDamage = 0;
        int warriorHealth = 100;
        int mageHealth = 100;
        bool gameOver = false;
        double probabilityMag = 0.08;
        double probabilityWarrior = 0.08;
        while (!gameOver)
        {
            warriorDamage = rng.Next(1, 10);
            mageDamage = rng.Next(1, 10);
            
            int crit1 = 0;
            int crit2 = 0;
            if (rngMag.NextDouble() < probabilityMag)
            {
                crit1 = rngMag.Next(20, 50);
         
            }
            else if (rngWarrior.NextDouble() < probabilityWarrior)
            {
                crit2 = rngWarrior.Next(15, 70);
            }

            mageHealth -= warriorDamage ;
            mageHealth -= crit2 ;
            warriorHealth -= mageDamage ;
            warriorHealth -= crit1;



                Console.ForegroundColor = ConsoleColor.Blue;
                if (crit1 > 0)
            {
                Console.Write($"{warriorName} inflicted {warriorDamage} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"+ CRIT {crit1} ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"damage upon {mageName}. {mageName} has {mageHealth} health remainig!");
            }
            else
            {
                Console.WriteLine($"{warriorName} inflicted {warriorDamage}  damage upon {mageName}. {mageName} has {mageHealth} health remainig!");
            }
               
                Console.ForegroundColor = ConsoleColor.Magenta;
            if (crit2 > 0)
            {
                Console.Write($"{mageName} inflicted {mageDamage} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"+ CRIT {crit2}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine( $" damage upon {warriorName}. {warriorName} has {warriorHealth} health remainig!");
            }
            else
            {
                Console.WriteLine($"{mageName} inflicted {mageDamage}  damage upon {warriorName}. {warriorName} has {warriorHealth} health remainig!");
            }
            

                if (warriorHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The Mage {mageName} is victorious with {mageHealth} health left");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The Warrior {warriorName} lost ");
                    gameOver = true;
                }
                else if (mageHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The Warrior {warriorName} is victorious with {warriorHealth} health left");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The Mage {mageName} lost ");
                    gameOver = true;
                }
            }
            Console.ResetColor();
        
    }
    }


