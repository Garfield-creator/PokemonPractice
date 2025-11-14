using System;
using System.Xml.Linq;

namespace PokemonPractice;

public class Attack(string name, ElementType type, int basePower)
{
    public string Name { get; private set; } = name;
    public ElementType Type { get; private set; } = type;
    public int BasePower { get; private set; } = basePower;

    public virtual void Use(int level)
	{
		Console.WriteLine(Name + " hit with a total power of " + (BasePower + level));
	}
}

public class LegendaryAttack(Attack baseAttack) : Attack(baseAttack.Name, baseAttack.Type, baseAttack.BasePower)
{
    public override void Use(int level)
    {
        Console.WriteLine(Name + " unleashes its potential with a total power of " + (BasePower + level * 2));
    }
}
