using Recipe.NET.Application.Dtos;
using Recipe.NET.Application.Interface;
using Recipe.NET.Application.Response;
using Recipe.NET.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static User user = new User(); // temporary to test
        public Task<BaseResponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<int> Register(UserRegisterDto userRegister)
        {
            CreatePasswordHash(userRegister.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            return new BaseResponse<int> { Data = user.UserId, Message = "Registration successful!" };
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
