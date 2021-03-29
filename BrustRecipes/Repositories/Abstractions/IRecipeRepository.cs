using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Entities.Recipes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrustRecipes.Repositories.Abstractions
{
    /// <summary>
    /// Exposes repository operations for recipes
    /// </summary>
    public interface IRecipeRepository
    {
        /// <summary>
        /// Find a recipe based on predicate
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IEnumerable<Recipe>> Find(Expression<Func<Recipe, bool>> expression);

        /// <summary>
        /// Return letters of the alphabet
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AlphabetEntity>> GetAlphabet();

        /// <summary>
        /// Return list of bases
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<BaseEntity>> GetBases();

        /// <summary>
        /// Return list of courses
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CourseEntity>> GetCourses();

        /// <summary>
        /// Return list of ingredients
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<IngredientEntity>> GetIngredients();
    }
}