using Recipe.NET.Application.Interface;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Interface
{
    public interface IRecipeRepository : IAsyncRepository<RecipeEntity>
    {
        
    }
}
