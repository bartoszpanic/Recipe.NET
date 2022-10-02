using Microsoft.EntityFrameworkCore;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RecipeEntity> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<RecipeEntity>()
                .HasKey(r => r.RecipeId);

            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.IngredientId);
        }
    }
}
