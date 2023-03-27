using System;



internal class Program
{
    static void Main()
    {
        Random rng = new Random();
        int years = 3;
        int months = 12;
        int days = 31;
        int hours = 24;
        int[,,,] temperaures = new int[years, months, days, hours];

        for (int year = 0; year < temperaures.GetLength(0); year++)
        {
            for (int month = 0; month < temperaures.GetLength(1); month++)
            {
                for (int day = 0; day < temperaures.GetLength(2); day++)
                {
                    for (int hour = 0; hour < temperaures.GetLength(3); hour++)
                    {
                        if (month >= 0 && month <= 2)
                        {
                            temperaures[year, month, day, hour] = rng.Next(-10, 15);
                        }
                        else if (month >= 3 && month <= 5)
                        {
                            temperaures[year, month, day, hour] = rng.Next(15, 25);
                        }
                        else if (month >= 6 && month <= 8)
                        {
                            temperaures[year, month, day, hour] = rng.Next(25, 35);
                        }
                        else if(month >= 9 && month <= 11)
                        {
                            temperaures[year, month, day, hour] = rng.Next(0, 25);
                        }
                    }
                }
            }
        }
        
    }
}

