using AutoMapper;
using Recipe.NET.Application.Dtos.Recipe;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Maper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RecipeEntity, RecipeDto>().ReverseMap();
        }
    }
}
