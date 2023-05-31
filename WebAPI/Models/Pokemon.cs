using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        //public int PokemonId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        //[Required]
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwner { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
        
            
    }
}
