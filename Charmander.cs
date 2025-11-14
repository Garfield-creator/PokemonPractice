using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonPractice;

internal class Charmander(int level, List<Attack> attacks) : FirePokemon(CHARMANDER, level, attacks), IEvolvable
{

    const string CHARMANDER = "Charmander";
    const string CHARMELEON = "Charmeleon";
    const string CHARIZARD = "Charizard";


    public override void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} has leveled up to level {Level}!");
        if (Level > 15 && Name == CHARMANDER) Evolve();
        if (Level > 35 && Name == CHARMELEON) Evolve();
    }

    public void Evolve()
    {
        if (Name == CHARMANDER) {
            Name = CHARMELEON;
            Level += 10;
            Console.WriteLine($"{CHARMANDER} is evolving... It is now a {CHARMELEON} and its level is " + Level);
        }
        else if (Name == CHARMELEON)
        {
            Name = CHARIZARD;
            Level += 10;
            Console.WriteLine($"{CHARMELEON} is evolving... It is now a {CHARIZARD} and its level is " + Level);
        }
    }

    public override void Speak()
    {
        String speak = "";
        switch (Name) {
            case CHARMANDER:
                speak = "char char";
                break;
            case CHARMELEON:
                speak = "char-meleon";
                break;
            case CHARIZARD:
                speak = "CHARIZARD";
                break;
        }
        Console.WriteLine($"{Name} says: {speak}!");
    }
}
