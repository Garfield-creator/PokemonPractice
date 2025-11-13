namespace PokemonPractice;

internal class Squirtle(int level, List<Attack> attacks) : GrassPokemon(SQUIRTLE, level, attacks), IEvolvable
{

    const string SQUIRTLE = "Squirtle";
    const string WARTORTLE = "Wartortle";
    const string BLASTOISE = "Blastoise";

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
