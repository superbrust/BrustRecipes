using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Prep Time Entity Configuration
    /// </summary>
    public class PrepTimeEntityConfiguration : IEntityTypeConfiguration<PrepTimeEntity>
    {
        /// <summary>
        /// Configure Prep Time Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<PrepTimeEntity> builder)
        {
            builder.ToTable("recipe_prep_time");
            builder.HasKey(x => x.PrepTimeId);
            builder.Property(p => p.PrepTimeId).HasColumnName("time_id");
            builder.Property(p => p.PrepTimeDescription).HasColumnName("time_desc");
        }
    }
}