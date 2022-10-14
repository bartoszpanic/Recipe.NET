using Recipe.NET.Application.Dtos.Recipe;
using Recipe.NET.Application.Interface;
using Recipe.NET.Application.Response;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Infrastructure.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly DataContext _context;
        public RecipeService(DataContext context)
        {
            _context = context;
        }

        public Task<BaseResponse<RecipeEntity>> CreateRecipe(RecipeDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<List<RecipeEntity>>> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<RecipeEntity>> GetRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<RecipeEntity>> UpdateRecipe(RecipeDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
