using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

using WebAPI.Data;
using AutoMapper;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepositiry;
        private readonly IMapper _mapper;
        public PokemonController(IPokemonRepository pokemonRepositiry,IMapper mapper) 
        {
            _pokemonRepositiry = pokemonRepositiry;
            _mapper = mapper;
     
        }
        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemon =_mapper.Map<List<PokemonDto>> (_pokemonRepositiry.GetPokemons());
     
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemon);
 
        }
        [HttpGet("{pokeId}")]
        [ProducesResponseType(200,Type =typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeid)
        {
            if (!_pokemonRepositiry.PokemonExists(pokeid))
                return NotFound();

            var pokemon  =_mapper.Map<PokemonDto> (_pokemonRepositiry.GetPokemon(pokeid));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemon);
        }
        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type= typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonRating(int pokeid)
        {
            if (!_pokemonRepositiry.PokemonExists(pokeid))
               return NotFound();

            var rating = _pokemonRepositiry.GetPokemonRating(pokeid);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }
    }
}
