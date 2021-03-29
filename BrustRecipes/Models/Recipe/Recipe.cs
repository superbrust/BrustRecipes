using BrustRecipes.Repositories.Entities.Recipes;
using System.Collections.Generic;

namespace BrustRecipes.Models.Recipe
{
    /// <summary>
    /// Represents a Recipe
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Base
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Course
        /// </summary>
        public string Course { get; set; }

        /// <summary>
        /// Ingredients
        /// </summary>
        public List<IngredientEntity> Ingredients { get; set; }

        /// <summary>
        /// Difficulty
        /// </summary>
        public string Difficulty { get; set; }

        /// <summary>
        /// Directions
        /// </summary>
        public string Directions { get; set; }

        /// <summary>
        /// Ethnicity
        /// </summary>
        public string Ethnicity { get; set; }

        /// <summary>
        /// Recipe Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Recipe Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PreparationTime
        /// </summary>
        public string PreparationTime { get; set; }

        /// <summary>
        /// Serving Size
        /// </summary>
        public long ServingSize { get; set; }

        /// <summary>
        /// Source
        /// </summary>
        public string Source { get; set; }
    }
}