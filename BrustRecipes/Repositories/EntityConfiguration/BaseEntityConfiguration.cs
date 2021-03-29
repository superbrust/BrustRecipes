using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Base Entity Configuration
    /// </summary>
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        /// <summary>
        /// Configure Base Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.ToTable("recipe_bases");
            builder.HasKey(x => x.BaseId);
            builder.Property(p => p.BaseId).HasColumnName("base_id");
            builder.Property(p => p.BaseDescription).HasColumnName("base_desc");
        }
    }
}