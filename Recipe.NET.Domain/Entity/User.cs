using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Domain.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public Guid UserGuid { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
