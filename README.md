using System;

public class Pet
{
    public PetType Type { get; private set; }
    public string Name { get; private set; }
    public PetStatus Status { get; private set; }

    public Pet(PetType type, string name)
    {
        Type = type;
        Name = name;
        Status = new PetStatus();
    }

    public void Feed()
    {
        Status.Hunger = Math.Max(1, Status.Hunger - 1);
        Status.Health = Math.Min(10, Status.Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreases, health improves slightly.");
    }

    public void Play()
    {
        Status.Happiness = Math.Min(10, Status.Happiness + 2);
        Status.Hunger = Math.Min(10, Status.Hunger + 1);
        Console.WriteLine($"You played with {Name}. Happiness increases but gets a bit hungrier.");
    }

    public void Rest()
    {
        Status.Health = Math.Min(10, Status.Health + 2);
        Status.Happiness = Math.Max(1, Status.Happiness - 1);
        Console.WriteLine($"{Name} had a rest. Health improves, happiness decreases slightly.");
    }

    public void CheckStatus()
    {
        Console.WriteLine($"{Name}'s status:\n- Hunger: {Status.Hunger}\n- Happiness: {Status.Happiness}\n- Health: {Status.Health}");
    }
}
