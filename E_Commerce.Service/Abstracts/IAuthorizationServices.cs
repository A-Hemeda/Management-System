﻿using E_Commerce.Data.Entites.Identity;
using E_Commerce.Data.Requests;
using E_Commerce.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Abstracts
{
    public interface IAuthorizationServices
    {
        Task<string> AddRoleAsync(string roleName);
        Task<bool> IsRoleExstists(string roleName);
        Task<List<Role>> GetRolesAsync();

      //  Task<string> EditRoleAsync(EditRoleCommand editRoleRequest);
        Task<string> DeleteRoleAsync(int roleId);
        Task<Role> GetRoleById(int id);
        Task<ManageUserRolesResult> ManageUserRolesData(User user);
        Task<string> UpdateUserRoles(UpdateUserRolesRequest request);
        Task<ManageUserClaimsResults> ManageUserClaimData(User user);
        Task<string> UpdateUserClaims(UpdateUserClaimsRequests request);
    }
}
