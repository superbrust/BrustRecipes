using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;

namespace BrustRecipes.Repositories
{
    public class MySQLDataContext : DbContext, IMySQLDataContext
    {
        public MySQLDataContext(DbContextOptions<MySQLDataContext> options) : base(options)
        { }

        public DbSet<BaseEntity> Bases { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<AlphabetEntity> Letters { get; set; }
        public DbSet<RecipeEntity> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\daveb\Dropbox\documents\BrustRecipes.mdb;");
            optionsBuilder.UseMySQL(@"Server = rds-mysql-brustrecipes.char2ahcmvzs.us-east-2.rds.amazonaws.com; Port = 3306; Database = BrustRecipes; Uid = admin; Pwd = recipes!; convert zero datetime=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetAssembly(typeof(JetDataContext)));
            base.OnModelCreating(modelBuilder);
        }
    }
}