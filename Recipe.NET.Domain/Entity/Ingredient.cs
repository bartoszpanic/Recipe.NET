using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Domain.Entity
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public Guid IngredientsGuid { get; set; }
        public string IngredientName { get; set; } = string.Empty;
    }
}
