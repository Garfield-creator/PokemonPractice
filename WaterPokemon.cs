namespace PokemonPractice;

class WaterPokemon : Pokemon
{
    public WaterPokemon(String name, int level, List<Attack> attacks) : base(name, level, attacks)
    {
        Type = ElementType.WATER;
    }
}