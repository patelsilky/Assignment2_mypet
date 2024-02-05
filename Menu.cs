# Assignment2_mypet
using System;

public static class Menu
{
    public static void DisplayMainMenu(Pet pet)
    {
        Console.WriteLine($"Main menu for {pet.Name}:");
        Console.WriteLine("1. Feed");
        Console.WriteLine("2. Play");
        Console.WriteLine("3. Rest");
        Console.WriteLine("4. Check status");
        Console.WriteLine("5. Exit");
    }
}
