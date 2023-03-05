using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        bool exit = false;
        string[] fruits = new string[]
        {
            "Orange",
            "Lemon"
        };

        while (!exit)
        {
            Console.Write("\n1. Add New Item" +
                "\n2. Edit Item" +
                "\n3. Remove Item" +
                "\n4. View All items" +
                "\n5. Exit" +
                "\n " +
                "\nYour choice:" +
                "\n");

            string checkInput = Console.ReadLine();
            int choice = checkInput.Any() && checkInput.All(l => char.IsNumber(l)) ? Convert.ToInt32(checkInput) : 0;

            switch (choice)
            {
                case 1:
                    if (fruits[fruits.Length - 1] != null)
                    {
                        Array.Resize(ref fruits, fruits.Length + 10);
                    }
                    Additem(fruits);

                    break;

                case 2:
                    EditItem(fruits);
                    break;

                case 3:
                    RemoveItem(fruits);
                    break;

                case 4:
                    Array.Sort(fruits, (a, b) => a == null ? 1 : b == null ? -1 : a.CompareTo(b));
                    ShowAllItems(fruits);

                    break;
                case 5:

                    exit = true;
                    break;

                default:
                    Console.WriteLine("Unrecognized option");
                    break;
            }
        }
    }

    private static void ShowAllItems(string[] fruits)
    {
        Console.WriteLine("\nCurrent Fruits:");

        foreach (string fruit in fruits.Where(f => f != null))
        {
            Console.WriteLine($"{Array.IndexOf(fruits, fruit) + 1}. {fruit}");
        }

        Console.WriteLine();
    }

    private static void RemoveItem(string[] fruits)
    {
        int chosenFruit;
        Console.Write("Which fruit do you want to remove :");
        string checkInput = Console.ReadLine();
        if (checkInput.All(l => char.IsNumber(l)))
        {
            chosenFruit = Convert.ToInt32(checkInput);
            Console.WriteLine($"{fruits[chosenFruit - 1]} was removed!");
            fruits[chosenFruit - 1] = null;
            ShiftArray(fruits);
        }

    }

    private static void ShiftArray(string[] fruits)
    {
        string[] tempArray = new string[fruits.Length];
        int tempArrayIndex = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] != null)
            {
                tempArray[tempArrayIndex] = fruits[i];
                tempArrayIndex++;
            }
        }

        Array.Copy(tempArray, fruits, tempArray.Length);
    }

    private static void EditItem(string[] fruits)
    {
        int chosenFruit = 0;
        Console.Write("Which fruit do you want to change :");
        string checkInput = Console.ReadLine();
        if (checkInput.All(l => char.IsNumber(l)))
        {
            chosenFruit = Convert.ToInt32(checkInput);

            Console.WriteLine("Please input a new item");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{fruits[chosenFruit - 1]}");
            Console.ResetColor();
            Console.Write(": ");
            Console.ForegroundColor = ConsoleColor.Green;
            fruits[chosenFruit - 1] = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(" ");
        }
    }

    private static void Additem(string[] fruits)
    {
        Console.WriteLine("Please add a new fruit");
        fruits[fruits.Count(l => !string.IsNullOrEmpty(l))] = Console.ReadLine();
    }
}

