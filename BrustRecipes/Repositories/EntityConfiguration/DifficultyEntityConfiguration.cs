using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Base Entity Configuration
    /// </summary>
    public class DifficultyEntityConfiguration : IEntityTypeConfiguration<DifficultyEntity>
    {
        /// <summary>
        /// Configure Base Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<DifficultyEntity> builder)
        {
            builder.ToTable("recipe_difficulty");
            builder.HasKey(x => x.DifficultyId);
            builder.Property(p => p.DifficultyId).HasColumnName("difficult_id");
            builder.Property(p => p.DifficultyDescription).HasColumnName("difficult_desc");
        }
    }
}