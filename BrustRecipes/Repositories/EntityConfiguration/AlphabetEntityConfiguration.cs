using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Alphabet Entity Configuration
    /// </summary>
    public class AlphabetEntityConfiguration : IEntityTypeConfiguration<AlphabetEntity>
    {
        /// <summary>
        /// Configure Alphabet Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<AlphabetEntity> builder)
        {
            builder.ToTable("alphabet");
            builder.HasKey(x => x.LetterId);
            builder.Property(p => p.LetterId).HasColumnName("letter_id");
            builder.Property(p => p.LetterDescription).HasColumnName("letter_desc");
        }
    }
}