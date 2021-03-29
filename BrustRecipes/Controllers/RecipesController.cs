using AutoMapper;
using BrustRecipes.Models;
using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Entities.Recipes;
using BrustRecipes.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrustRecipes.Controllers
{
    /// <summary>
    /// Controller for Recipe actions
    /// </summary>
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : WebApiControllerBase
    {
        private readonly IRecipeService recipeService;

        /// <summary>
        /// Responsible for Recipes
        /// </summary>
        /// <param name="mapper">Automapper instance</param>
        /// <param name="recipeService"></param>
        public RecipesController(IMapper mapper, IRecipeService recipeService) : base(mapper)
        {
            this.recipeService = recipeService;
        }

        /// <summary>
        /// Retrieve the letters of the alphabet
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("alphabet")]
        [ProducesResponseType(typeof(List<AlphabetEntity>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAlphabet()
        {
            var results = await recipeService.GetAlphabet();
            return Ok(mapper.Map<IEnumerable<AlphabetEntity>>(results));
        }

        /// <summary>
        /// Retrieve the base descriptions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("bases")]
        [ProducesResponseType(typeof(List<BaseEntity>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBases()
        {
            var results = await recipeService.GetBases();
            return Ok(mapper.Map<IEnumerable<BaseEntity>>(results));
        }
        /// <summary>
        /// Retrieve the course descriptions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("courses")]
        [ProducesResponseType(typeof(List<CourseEntity>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCourses()
        {
            var results = await recipeService.GetCourses();
            return Ok(mapper.Map<IEnumerable<CourseEntity>>(results));
        }

        /// <summary>
        /// Retrieve list of all ingredients
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ingredients")]
        [ProducesResponseType(typeof(List<IngredientEntity>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetIngredients()
        {
            var results = await recipeService.GetIngredients();
            return Ok(mapper.Map<IEnumerable<IngredientEntity>>(results));
        }

        /// <summary>
        /// Search Recipes using specified parameters
        /// </summary>
        /// <param name="searchParams"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("recipes")]
        [ProducesResponseType(typeof(List<RecipeReturnModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SearchRecipes([FromQuery] RecipeSearchParameters searchParams)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // Adjust for asterix values
            if (searchParams.Base == "*") searchParams.Base = null;
            if (searchParams.BeginsWith == "*") searchParams.BeginsWith = null;
            if (searchParams.Course == "*") searchParams.Course = null;

            // Fetch results
            var results = await recipeService.RecipeSearch(mapper.Map<RecipeSearchParameters>(searchParams));

            return Ok(mapper.Map<IEnumerable<RecipeReturnModel>>(results));
        }
    }
}