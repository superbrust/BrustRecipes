using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Entities.Recipes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrustRecipes.Services.Abstractions
{
    /// <summary>
    /// Exposes Recipe operations
    /// </summary>
    public interface IRecipeService
    {
        /// <summary>
        /// Retrieves the letters of the alphabet
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AlphabetEntity>> GetAlphabet();

        /// <summary>
        /// Retrieves List of Bases
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<BaseEntity>> GetBases();

        /// <summary>
        /// Retrieves List of Courses
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CourseEntity>> GetCourses();

        /// <summary>
        /// Retrieves List of Ingredients
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<IngredientEntity>> GetIngredients();

        /// <summary>
        /// Retrieves recipes based on search parameters
        /// </summary>
        /// <param name="SearchParameters"></param>
        /// <returns></returns>
        Task<IEnumerable<Recipe>> RecipeSearch(RecipeSearchParameters SearchParameters);
    }
}