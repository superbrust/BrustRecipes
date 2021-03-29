using System;

namespace BrustRecipes.Repositories.Entities.Recipes
{
    /// <summary>
    /// Ingredients
    /// </summary>
    public class IngredientEntity
    {
        ///// <summary>
        ///// Id to use for primary key
        ///// </summary>
        //public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Ingredient Name
        /// </summary>
        public string IngredientName { get; set; }

        /// <summary>
        /// Recipe Id
        /// </summary>
        public long RecipeId { get; set; }

        /// <summary>
        /// Map Order
        /// </summary>
        public long MapOrder { get; set; }
    }
}