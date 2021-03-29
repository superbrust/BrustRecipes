using BrustRecipes.Repositories.Entities.Recipes;
using System.Collections.Generic;

namespace BrustRecipes.Models
{
    public class RecipeReturnModel
    {
        public string Base { get; set; }
        public string Comments { get; set; }
        public string Course { get; set; }
        public string Difficulty { get; set; }
        public string Directions { get; set; }
        public string Ethnicity { get; set; }
        public long Id { get; set; }
        public List<IngredientReturnModel> Ingredients { get; set; }
        public string Name { get; set; }
        public string PreparationTime { get; set; }
        public long ServingSize { get; set; }
        public string Source { get; set; }
    }
}