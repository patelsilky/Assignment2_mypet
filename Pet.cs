using System;
//Pet class defination 
class Pet
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }
    //default constructor
    public Pet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 5;
        Happiness = 5;
        Health = 8;
    }
    //feed method
    public void Feed()
    {
        Hunger -= 1;
        if (Hunger < 0) Hunger = 0;
        Health++;
        Console.WriteLine($" You Fed {Name}.His hunger decreases,and health improves Slightly.\n");
    }
    //play method
    public void Play()
    {
        Happiness += 2;
        if (Happiness > 10) Happiness = 10;
        Hunger += 1;
        if (Hunger > 10) Hunger = 10;
        Console.WriteLine($"You Play with {Name}.His hunger Improves,and health improves Slightly.\n");
    }
    //rest method
    public void Rest()
    {
        Health += 2;
        if (Health > 10) Health = 10;
        Happiness--;
        if (Happiness < 0) Happiness = 0;
        Console.WriteLine($" resting time {Name}.His Happiness decreases,and health improves Slightly.\n");
    }
    //status after calling methods
    public void Status()
    {
        Console.WriteLine($"{Name}'s Status:");
        Console.WriteLine($"-Hunger: {Hunger}");
        Console.WriteLine($"-HungerHappiness: {Happiness}");
        Console.WriteLine($"-Health: {Health}\n");
    }
}
