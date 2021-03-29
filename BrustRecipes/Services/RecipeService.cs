using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Abstractions;
using BrustRecipes.Repositories.Entities.Recipes;
using BrustRecipes.Services.Abstractions;
using BrustRecipes.Services.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrustRecipes.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        public RecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }

        /// <summary>
        /// Retrieves letters of the alphabet
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<AlphabetEntity>> GetAlphabet()
        {
            return recipeRepository.GetAlphabet();
        }

        /// <summary>
        /// Retrieves list of Bases
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<BaseEntity>> GetBases()
        {
            return recipeRepository.GetBases();
        }

        /// <summary>
        /// Retrieves list of Courses
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CourseEntity>> GetCourses()
        {
            return recipeRepository.GetCourses();
        }

        /// <summary>
        /// Retrieves list of Ingredients
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<IngredientEntity>> GetIngredients()
        {
            return recipeRepository.GetIngredients();
        }
        /// <summary>
        /// Returns list of Recipes based on input search criteria
        /// </summary>
        /// <param name="SearchParameters"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Recipe>> RecipeSearch(RecipeSearchParameters SearchParameters)
        {
            var predicate = PredicateBuilder.True<Recipe>();

            //if (SearchParameters.Base.HasValue)
            //{
            //    predicate = predicate.And(x => x.Base == SearchParameters.Base.Value);
            //}
            if (!string.IsNullOrEmpty(SearchParameters.Base))
            {
                predicate = predicate.And(x => x.Base == SearchParameters.Base);
            }

            //if (SearchParameters.Course.HasValue)
            //{
            //    predicate = predicate.And(x => x.Course == SearchParameters.Course.Value);
            //}
            if (!string.IsNullOrEmpty(SearchParameters.Course))
            {
                predicate = predicate.And(x => x.Course == SearchParameters.Course);
            }

            if (!string.IsNullOrEmpty(SearchParameters.BeginsWith))
            {
                predicate = predicate.And(x => x.Name.StartsWith(SearchParameters.BeginsWith));
            }

            // Search
            var results = await recipeRepository.Find(predicate);

            return results;
        }
    }
}