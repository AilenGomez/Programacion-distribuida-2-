﻿using Microsoft.AspNetCore.Http;
using Notificaciones.Application.Common.Interfaces.Services;

namespace Notificaciones.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public string GetUser()
        {
            string userName = _httpContextAccessor.HttpContext?.Request?.Headers["UserName"];
            return string.IsNullOrEmpty(userName) ? "S/D" : userName;
        }
    }
}
