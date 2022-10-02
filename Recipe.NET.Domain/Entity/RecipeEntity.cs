using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Domain.Entity
{
    public class RecipeEntity
    {
        public int RecipeId { get; set; }
        public Guid RecipeGuid { get; set; }
        public string RecipeName { get; set; } = string.Empty;
        public string RecipeDescription { get; set; } = string.Empty;
        public string RecipeShortDescription { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = null!;

        public User User { get; set; }
    }
}
