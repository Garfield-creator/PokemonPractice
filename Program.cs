using System;

namespace PokemonPractice;
public enum ElementType
{
    FIRE,
    WATER,
    GRASS,
}

class PokemonGame
{
    
    static void Main()
    {
        Attack flamethrower = new("Flamethrower", ElementType.FIRE, 12);
        Attack ember = new("Ember", ElementType.FIRE, 6);
        Attack hydroPump = new("Hydro Pump", ElementType.WATER, 13);
        Attack waterGun = new("Water Gun", ElementType.WATER, 7);
        Attack solarBeam = new("Solar Beam", ElementType.GRASS, 17);
        Attack razorLeaf = new("Razor Leaf", ElementType.GRASS, 6);
        List<Pokemon> PokemonTeam =
        [
            new Bulbasaur(13, [solarBeam, razorLeaf]),
            new Squirtle(12, [hydroPump, waterGun]),
            new Charmander(13, [flamethrower, ember]),
        ];
        foreach (Pokemon pokemon in PokemonTeam)
        {
            pokemon.RaiseLevel();
            pokemon.Attack();
            if (pokemon is IEvolvable evolvable) evolvable.Evolve();
        }
    }
}

