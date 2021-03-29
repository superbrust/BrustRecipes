using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    ///  Configure the Recipe Entity
    /// </summary>
    public class RecipeEntityConfiguration : IEntityTypeConfiguration<RecipeEntity>
    {
        public void Configure(EntityTypeBuilder<RecipeEntity> builder)
        {
            builder.ToTable("recipe_recipes");
            builder.HasKey(x => x.RecipeId);
            builder.Property(p => p.RecipeId).HasColumnName("recipe_id");
            builder.Property(p => p.RecipeName).HasColumnName("recipe_name");
            builder.Property(p => p.RecipeEthnicityId).HasColumnName("recipe_ethnic");
            builder.Property(p => p.RecipeBaseId).HasColumnName("recipe_base");
            builder.Property(p => p.RecipeCourseId).HasColumnName("recipe_course");
            builder.Property(p => p.RecipePrepTimeId).HasColumnName("recipe_prep_time");
            builder.Property(p => p.RecipeDifficultyId).HasColumnName("recipe_difficulty");
            builder.Property(p => p.RecipeServingSize).HasColumnName("recipe_serving_size");
            builder.Property(p => p.RecipeDirections).HasColumnName("recipe_directions");
            builder.Property(p => p.RecipeComments).HasColumnName("recipe_comments");
            builder.Property(p => p.RecipeSource).HasColumnName("recipe_source");
            builder.Property(p => p.RecipeCost).HasColumnName("recipe_cost");
            builder.Property(p => p.RecipeModified).HasColumnName("recipe_modified");
            builder.Property(p => p.RecipePicture).HasColumnName("recipe_picture");
            builder.Property(p => p.RecipePictureType).HasColumnName("recipe_picture_type");
            builder.Property(p => p.RecipePrivate).HasColumnName("recipe_private");
            builder.Property(p => p.RecipeSystem).HasColumnName("recipe_system");
            builder.Property(p => p.RecipeOwner).HasColumnName("recipe_owner");

            builder.HasOne(x => x.RecipeBase).WithMany().HasForeignKey(x => x.RecipeBaseId).HasPrincipalKey(x => x.BaseId);
            builder.HasOne(x => x.RecipeCourse).WithMany().HasForeignKey(x => x.RecipeCourseId).HasPrincipalKey(x => x.CourseId);
            builder.HasOne(x => x.RecipeEthnicity).WithMany().HasForeignKey(x => x.RecipeEthnicityId).HasPrincipalKey(x => x.EthnicityId);
            builder.HasOne(x => x.RecipePrepTime).WithMany().HasForeignKey(x => x.RecipePrepTimeId).HasPrincipalKey(x => x.PrepTimeId);
            builder.HasOne(x => x.RecipeDifficulty).WithMany().HasForeignKey(x => x.RecipeDifficultyId).HasPrincipalKey(x => x.DifficultyId);

            builder.HasMany(x => x.RecipeIngredients).WithOne().HasForeignKey(x => x.RecipeId);

        }
    }
}
