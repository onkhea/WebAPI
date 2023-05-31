using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        { 
            _context = context;
        }

        public ICollection<Pokemon> GetPokemon(int id)
        {
            return _context.pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemon(string name)
        {
            return _context.pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);

            if (review.Count() > 0)
                return 0;

            return ((decimal)review.Sum(r =>r.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int Pokemonid)
        {
            throw new NotImplementedException();
        }
    }
}
