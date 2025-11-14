namespace PokemonPractice;

abstract class GrassPokemon : Pokemon
{
    public GrassPokemon(String name, int level, List<Attack> attacks) : base(name, level, attacks)
    {
        Type = ElementType.GRASS;
    }
}