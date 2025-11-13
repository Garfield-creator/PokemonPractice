using System;

namespace PokemonPractice;

public class Attack(string name, ElementType type, int basePower)
{
    public string Name { get; private set; } = name;
    public ElementType Type { get; private set; } = type;
    public int BasePower { get; private set; } = basePower;

    public void Use(int level)
	{
		Console.WriteLine(Name + " hit with a total power of " + (BasePower + level));
	}
}
