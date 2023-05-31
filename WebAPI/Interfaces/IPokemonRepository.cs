using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating (int pokemonID);
        bool PokemonExists (int Pokemonid);

    }
}
