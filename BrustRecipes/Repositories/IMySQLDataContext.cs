using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using System;

namespace BrustRecipes.Repositories
{
    /// <summary>
    /// Entity link to repository table
    /// </summary>
    public interface IMySQLDataContext : IDisposable
    {
        /// <summary>
        /// Bases
        /// </summary>
        DbSet<BaseEntity> Bases { get; set; }

        /// <summary>
        /// Courses
        /// </summary>
        DbSet<CourseEntity> Courses { get; set; }

        /// <summary>
        /// Ingredients
        /// </summary>
        DbSet<IngredientEntity> Ingredients { get; set; }

        /// <summary>
        /// Letters of the alphabet
        /// </summary>
        DbSet<AlphabetEntity> Letters { get; set; }

        /// <summary>
        /// Recipes
        /// </summary>
        DbSet<RecipeEntity> Recipes { get; set; }
    }
}