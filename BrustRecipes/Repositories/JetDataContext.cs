using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;

namespace BrustRecipes.Repositories
{
    public class JetDataContext : DbContext, IJetDataContext
    {
        public JetDataContext(DbContextOptions<JetDataContext> options) : base(options)
        { }

        public DbSet<BaseEntity> Bases { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<AlphabetEntity> Letters { get; set; }
        public DbSet<RecipeEntity> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\daveb\Dropbox\documents\BrustRecipes.mdb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetAssembly(typeof(JetDataContext)));
            base.OnModelCreating(modelBuilder);
        }
    }
}