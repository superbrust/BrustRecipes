namespace BrustRecipes.Models.Recipe
{
    /// <summary>
    /// Define search parameters for recipes
    /// </summary>
    public class RecipeSearchParameters
    {
        /// <summary>
        /// Search by base
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        /// Search by first letter of recipe name
        /// </summary>
        public string BeginsWith { get; set; }

        /// <summary>
        /// Search by course
        /// </summary>
        public string Course { get; set; }
    }
}