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
        Attack bubblebeam = new("Bubblebeam", ElementType.WATER, 13);
        Attack waterGun = new("Water Gun", ElementType.WATER, 7);
        Attack razorLeaf = new("Razor Leaf", ElementType.GRASS, 11);
        Attack vineWhip = new("Vine Whip", ElementType.GRASS, 6);

        Attack solarBeam = new("Solar Beam", ElementType.GRASS, 18);
        LegendaryAttack legendarySolarBeam = new(solarBeam);
        Attack fireBlast = new("Fire Blast", ElementType.FIRE, 16);
        LegendaryAttack legendaryFireBlast = new(fireBlast);
        Attack hydroPump = new("Hydro Pump", ElementType.GRASS, 17);
        LegendaryAttack legendaryHydroPump = new(hydroPump);

        List<Pokemon> PokemonTeam =
        [
            new Bulbasaur(13, [razorLeaf, vineWhip]),
            new Squirtle(12, [bubblebeam, waterGun]),
            new Charmander(13, [flamethrower, ember]),
        ];
        foreach (Pokemon pokemon in PokemonTeam)
        {
            pokemon.Speak();
            pokemon.RaiseLevel();
            pokemon.Attack();
            if (pokemon is IEvolvable evolvable) evolvable.Evolve();
        }
    }
}

