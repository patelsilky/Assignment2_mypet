class Program
{
    //main method
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Silky's Pet Simulator!");
        Console.WriteLine("Choose a pet type");
        Console.WriteLine("1. Cat");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3. Rabbit \n");
        Console.WriteLine("User Input: ");
        //user input
        int choosenNumber = int.Parse(Console.ReadLine());
        string typechoose;
        //switch case for type
        switch (choosenNumber)
        {
            case 1:
            typechoose = "Cat";
            break;
            case 2:
            typechoose = "Dog";
            break;
            case 3:
            typechoose = "Rabbit";
            break;
            default:
            Console.WriteLine("Invalid choice. Defaulting to Cat.");
            typechoose = "Cat"; 
            break;
        }
        Console.WriteLine($"\nYou've Chosen a {typechoose}. What would you like to name your pet?");
        Console.WriteLine("User Input: ");
        string name = Console.ReadLine();
        //make new pet Using Calling pet class
        Pet pet = new Pet(typechoose, name);
        Console.WriteLine($"\nWelcome, {pet.Name}! Let's Take good care of him.");
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine($"1. Feed {pet.Name}");
            Console.WriteLine($"2. Play with {pet.Name}");
            Console.WriteLine($"3. Let {pet.Name} Rest");
            Console.WriteLine($"4. Check {pet.Name}'s status");
            Console.WriteLine("5. Exit");
            Console.WriteLine("User Input: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.Rest();
                    break;
                case 4:
                    pet.Status();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
