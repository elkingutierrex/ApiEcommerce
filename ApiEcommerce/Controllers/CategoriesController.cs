using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ApiEcommerce.Repository.IRepository;
using AutoMapper;
using ApiEcommerce.Models.Dtos;

namespace ApiEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetCategories()
        {
            var categories = _categoryRepository.GetCategories();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            return Ok(categoriesDto);

        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetCategory(int id)
        {
            var categories = _categoryRepository.GetCategory(id);
            if (categories == null)
            {
                return NotFound();
            }
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            return Ok(categoriesDto);

        }


    }
}