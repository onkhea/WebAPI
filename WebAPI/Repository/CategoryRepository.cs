using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext dataDbcontext) 
        {
            _context = dataDbcontext;
        }
        public bool CategoriesExists(int id)
        {
            return _context.Category.Any(c=>c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Category.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Category.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int id)
        {
          return _context.pokemonCategory.Where(e =>e.CategoryId == id).Select(c =>c.Pokemon).ToList();
        }
    }
}
