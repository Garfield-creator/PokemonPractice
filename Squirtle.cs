namespace PokemonPractice;

internal class Squirtle(int level, List<Attack> attacks) : GrassPokemon(SQUIRTLE, level, attacks), IEvolvable
{

    const string SQUIRTLE = "Squirtle";
    const string WARTORTLE = "Wartortle";
    const string BLASTOISE = "Blastoise";


    public override void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} has leveled up to level {Level}!");
        if (Level > 17 && Name == SQUIRTLE) Evolve();
        if (Level > 31 && Name == WARTORTLE) Evolve();
    }

    public void Evolve()
    {
        if (Name == SQUIRTLE)
        {
            Name = WARTORTLE;
            Level += 10;
            Console.WriteLine($"{SQUIRTLE} is evolving... It is now a {WARTORTLE} and its level is " + Level);
        }
        else if (Name == WARTORTLE)
        {
            Name = BLASTOISE;
            Level += 10;
            Console.WriteLine($"{WARTORTLE} is evolving... It is now a {BLASTOISE} and its level is " + Level);
        }
    }
}
