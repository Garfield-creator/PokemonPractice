namespace PokemonPractice;

internal class Bulbasaur(int level, List<Attack> attacks) : GrassPokemon(BULBASAUR, level, attacks), IEvolvable
{

    const string BULBASAUR = "Bulbasaur";
    const string IVYSAUR = "Ivysaur";
    const string VENUSAUR = "Venusaur";

    public override void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} has leveled up to level {Level}!");
        if (Level > 13 && Name == BULBASAUR) Evolve();
        if (Level > 35 && Name == IVYSAUR) Evolve();
    }

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
    public override void Speak()
    {
        String speak = "";
        switch (Name)
        {
            case BULBASAUR:
                speak = "Bulba";
                break;
            case IVYSAUR:
                speak = "Ivy ivy";
                break;
            case VENUSAUR:
                speak = "Veenuu";
                break;
        }
        Console.WriteLine($"{Name} says: {speak}!");
    }
}
