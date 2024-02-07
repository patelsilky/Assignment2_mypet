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
