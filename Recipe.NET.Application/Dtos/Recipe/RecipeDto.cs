using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Dtos.Recipe
{
    public class RecipeDto
    {
        public string RecipeName { get; set; } = string.Empty;
        public string RecipeDescription { get; set; } = string.Empty;
        public string RecipeShortDescription { get; set; } = string.Empty;
    }
}
