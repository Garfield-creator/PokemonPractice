namespace PokemonPractice;

abstract class FirePokemon : Pokemon
{
    public FirePokemon(String name, int level, List<Attack> attacks) : base(name, level, attacks)
    {
        Type = ElementType.FIRE;
    }
}
