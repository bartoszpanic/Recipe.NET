using Recipe.NET.Application.Dtos.Recipe;
using Recipe.NET.Application.Response;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Interface
{
    public interface IRecipeService
    {
        Task<BaseResponse<RecipeEntity>> CreateRecipe(RecipeDto dto);
        Task<BaseResponse<RecipeEntity>> UpdateRecipe(RecipeDto dto);
        Task<BaseResponse<bool>> DeleteRecipe(int id);
        Task<BaseResponse<RecipeEntity>> GetRecipe(int id);
        Task<BaseResponse<List<RecipeEntity>>> GetAllRecipes();
    }
}
