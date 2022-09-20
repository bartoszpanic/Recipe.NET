﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.NET.Application.Interface
{
    public interface IUserRepository
    {
        Task<int> Register();
        Task<string> Login();
    }
}
