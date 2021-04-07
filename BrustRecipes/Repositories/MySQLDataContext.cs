using BrustRecipes.Repositories.Entities.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;

namespace BrustRecipes.Repositories
{
    /// <summary>
    /// MySQL Data Context
    /// </summary>
    public class MySQLDataContext : DbContext, IMySQLDataContext
    {
        /// <summary>
        /// Contstructor
        /// </summary>
        /// <param name="options"></param>
        public MySQLDataContext(DbContextOptions<MySQLDataContext> options) : base(options)
        { }

        /// <summary>
        /// Base Entity
        /// </summary>
        public DbSet<BaseEntity> Bases { get; set; }

        /// <summary>
        /// Course Entity
        /// </summary>
        public DbSet<CourseEntity> Courses { get; set; }

        /// <summary>
        /// Ingredient Entity
        /// </summary>
        public DbSet<IngredientEntity> Ingredients { get; set; }

        /// <summary>
        /// Alphabet Entity
        /// </summary>
        public DbSet<AlphabetEntity> Letters { get; set; }

        /// <summary>
        /// Recipe Entity
        /// </summary>
        public DbSet<RecipeEntity> Recipes { get; set; }

        /// <summary>
        /// Provides connection string
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\daveb\Dropbox\documents\BrustRecipes.mdb;");
            optionsBuilder.UseMySQL(@"Server = rds-mysql-brustrecipes.char2ahcmvzs.us-east-2.rds.amazonaws.com; Port = 3306; Database = BrustRecipes; Uid = admin; Pwd = recipes!; convert zero datetime=True");
        }

        /// <summary>
        /// Model Builder logic
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetAssembly(typeof(MySQLDataContext)));
            base.OnModelCreating(modelBuilder);
        }
    }
}