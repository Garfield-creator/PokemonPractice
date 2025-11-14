using System.Diagnostics.CodeAnalysis;

namespace PokemonPractice;

abstract class Pokemon
{
    public string Name { get; protected set; }
    public int Level { get; protected set; }
    public ElementType Type { get; protected set; }
    public List<Attack> Attacks { get; private set; }

    private readonly Random Random = new();

    public Pokemon(String name, int level, List<Attack> attacks)
    {
        if (String.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 15)
            throw new ArgumentException("To long or short or blank.", nameof(name));
        if (level < 1)
            throw new ArgumentException("Level less than 1", nameof(level));
        Name = name;
        Level = level;
        Attacks = attacks;
    }

    public void RandomAttack() 
    {
        Attacks[Random.Next(Attacks.Count)].Use(Level);
    }
    public void Attack() 
    {
        Console.WriteLine("Pick a move");
        for (int i = 0; i < Attacks.Count; i++)
        {
            Console.WriteLine("[" + (i + 1) + "] " + Attacks[i].Name);
        }
        int choice = 0;
        while (choice < 1 || choice > Attacks.Count)
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice) || choice < 1 || choice > Attacks.Count) Console.WriteLine("Pick a valid attack!");
            else Attacks[choice - 1].Use(Level);
        }
    }

    public virtual void RaiseLevel() {
        Level++;
        Console.WriteLine($"{Name} has leveled up to level {Level}!");
    }
}
