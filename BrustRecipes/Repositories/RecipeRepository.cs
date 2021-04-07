using AutoMapper;
using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Abstractions;
using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrustRecipes.Repositories
{
    /// <summary>
    /// Provides access to the Recipe Aggregate Root
    /// </summary>
    public class RecipeRepository : RepositoryBase<Recipe>, IRecipeRepository
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Mapper"></param>
        /// <param name="Context"></param>
        public RecipeRepository(IMapper Mapper, IMySQLDataContext Context) : base(Mapper, Context)
        {
        }

        /// <summary>
        /// Retrieve Recipes bases on an expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Task<IEnumerable<Recipe>> Find(Expression<Func<Recipe, bool>> expression)
        {
            var entityExpression = Mapper.Map<Expression<Func<RecipeEntity, bool>>>(expression);

            var resultList = _context.Recipes
                .Include(x => x.RecipeBase)
                .Include(x => x.RecipeCourse)
                .Include(x => x.RecipeEthnicity)
                .Include(x => x.RecipePrepTime)
                .Include(x => x.RecipeDifficulty)
                .Include(x => x.RecipeIngredients)
                .Where(entityExpression)
                .OrderBy(x => x.RecipeName)
                .ToListAsync();

            return resultList.ContinueWith<IEnumerable<Recipe>>(x =>
            {
                return Mapper.Map<IEnumerable<Recipe>>(x.Result);
            });
        }

        public async Task<IEnumerable<AlphabetEntity>> GetAlphabet()
        {
            var result = await _context.Letters
                .OrderBy(c => c.LetterId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<AlphabetEntity>>(result);
        }

        public async Task<IEnumerable<BaseEntity>> GetBases()
        {
            var result = await _context.Bases
                .OrderBy(b => b.BaseId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<BaseEntity>>(result);
        }

        public async Task<IEnumerable<CourseEntity>> GetCourses()
        {
            var result = await _context.Courses
                .OrderBy(c => c.CourseId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<CourseEntity>>(result);
        }

        public async Task<IEnumerable<IngredientEntity>> GetIngredients()
        {
            var result = await _context.Ingredients
                .OrderBy(c => c.RecipeId)
                .ThenBy(c => c.MapOrder)
                .ToListAsync();

            return Mapper.Map<IEnumerable<IngredientEntity>>(result);
        }
    }
}