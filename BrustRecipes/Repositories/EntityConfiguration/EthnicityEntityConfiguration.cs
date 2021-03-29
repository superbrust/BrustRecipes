using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Ethnicity Entity Configuration
    /// </summary>
    public class EthnicityEntityConfiguration : IEntityTypeConfiguration<EthnicityEntity>
    {
        /// <summary>
        /// Configure Ethnicity Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<EthnicityEntity> builder)
        {
            builder.ToTable("recipe_ethnicity");
            builder.HasKey(x => x.EthnicityId);
            builder.Property(p => p.EthnicityId).HasColumnName("ethnic_id");
            builder.Property(p => p.EthnicityDescription).HasColumnName("ethnic_desc");
        }
    }
}