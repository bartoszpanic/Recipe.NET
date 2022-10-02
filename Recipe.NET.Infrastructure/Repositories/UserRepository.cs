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
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context; 
        }
        public Task<BaseResponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<int> Register(User user, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            _context.Add(user); 
            _context.SaveChanges();

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
