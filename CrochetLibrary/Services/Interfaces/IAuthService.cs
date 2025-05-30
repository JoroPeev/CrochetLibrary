﻿using CrochetLibrary.Models.Auth;
using Microsoft.AspNetCore.Identity;

namespace CrochetLibrary.Services.Auth
{
    public interface IAuthService
    {
        Task<IdentityResult> RegisterAsync(RegisterModel model);
        Task<string?> LoginAsync(LoginModel model);
        Task<bool> AddAdminRoleAsync(string email);
    }
}
