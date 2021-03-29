using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrustRecipes.Repositories.EntityConfiguration
{
    /// <summary>
    /// Course Entity Configuration
    /// </summary>
    public class CourseEntityConfiguration : IEntityTypeConfiguration<CourseEntity>
    {
        /// <summary>
        /// Configure Course Entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {
            builder.ToTable("recipe_courses");
            builder.HasKey(x => x.CourseId);
            builder.Property(p => p.CourseId).HasColumnName("course_id");
            builder.Property(p => p.CourseDescription).HasColumnName("course_desc");
        }
    }
}