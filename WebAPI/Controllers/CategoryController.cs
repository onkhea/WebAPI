using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/comtroller")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200 , Type = typeof(IEnumerable<>))]
        public ActionResult GetActionResult()
        {
            return null;
            //var pokemons = _mapper.Map<List<PokemonDto>>(_categoryRepository.get)
        }
    }
}
