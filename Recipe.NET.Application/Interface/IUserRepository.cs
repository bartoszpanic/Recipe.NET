using Recipe.NET.Application.Dtos;
using Recipe.NET.Application.Response;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Interface
{
    public interface IUserRepository
    {
        Task<BaseResponse<int>> Register(User user, string password);
        Task<BaseResponse<string>> Login(string email, string password);
    }
}
