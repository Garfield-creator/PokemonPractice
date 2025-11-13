namespace PokemonPractice;

internal class Bulbasaur(int level, List<Attack> attacks) : GrassPokemon(BULBASAUR, level, attacks), IEvolvable
{

    const string BULBASAUR = "Bulbasaur";
    const string IVYSAUR = "Ivysaur";
    const string VENUSAUR = "Venusaur";

    public void Evolve()
    {
        if (Name == BULBASAUR)
        {
            Name = IVYSAUR;
            Level += 10;
            Console.WriteLine($"{BULBASAUR} is evolving... It is now a {IVYSAUR} and its level is " + Level);
        }
        else if (Name == IVYSAUR)
        {
            Name = VENUSAUR;
            Level += 10;
            Console.WriteLine($"{IVYSAUR} is evolving... It is now a {VENUSAUR} and its level is " + Level);
        }
    }
}
