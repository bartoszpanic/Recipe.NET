using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Interface
{
    public interface IUserRepository
    {
        void Register();
        Task<string> Login();
    }
}
