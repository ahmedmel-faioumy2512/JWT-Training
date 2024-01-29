using JWT_vtstraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_vtstraining.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisreAsync(RegisterModel model);

        Task<AuthModel> GetTokeneAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
