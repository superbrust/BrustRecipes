using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Ingredient Entity Configuration
    /// </summary>
    public class IngredientEntityConfiguration : IEntityTypeConfiguration<IngredientEntity>
    {
        /// <summary>
        /// Configure Ingredient Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<IngredientEntity> builder)
        {
            builder.ToTable("brust_recipe_ingredients");
            builder.HasKey(x => new { x.RecipeId, x.MapOrder });
            builder.Property(p => p.RecipeId).HasColumnName("recipe_id");
            builder.Property(p => p.MapOrder).HasColumnName("map_order");
            builder.Property(p => p.IngredientName).HasColumnName("ingredient_name");
        }
    }
}