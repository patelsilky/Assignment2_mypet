using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type of pet:\n1. Cat\n2. Dog\n3. Rabbit");
        var petTypeInput = Console.ReadLine();
        PetType petType = (PetType)Enum.Parse(typeof(PetType), petTypeInput);

        Console.WriteLine("What would you like to name your pet?");
        string petName = Console.ReadLine();

        Pet pet = new Pet(petType, petName);
        Console.WriteLine($"Welcome, {pet.Name}! Let's take good care of him.");

        bool exit = false;
        while (!exit)
        {
            Menu.DisplayMainMenu(pet);
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pet.Feed();
                    break;
                case "2":
                    pet.Play();
                    break;
                case "3":
                    pet.Rest();
                    break;
                case "4":
                    pet.CheckStatus();
                    break;
                case "5":
                    Console.WriteLine($"Thank you for playing with {pet.Name}. Goodbye!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
