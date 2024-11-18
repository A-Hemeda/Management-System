﻿using E_Cmmerce.Base;
using E_Commerce.Core.Features.Authorization.Commands.Models;
using E_Commerce.Core.Features.Authorization.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace E_Cmmerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize(Roles = "Admin")]
    public class AuthorizationController : AppControllerBase
    {
        [HttpPost("Create")]

        public async Task<IActionResult> Create([FromForm] AddRoleCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet("GetRoleList")]
        public async Task<IActionResult> GetRoleList()
        {
            var response = await Mediator.Send(new GetRolesListQuery());
            return NewResult(response);
        }

        [HttpGet("GetRoleById")]
        public async Task<IActionResult> GetRoleById( int id)
        {
            var response = await Mediator.Send(new GetRoleByIdQuery(id));
            return NewResult(response);
        }

        [HttpGet("ManageUserRoles")]
        public async Task<IActionResult> ManageUserRoles(int Id)
        {
            var response = await Mediator.Send(new ManageUserRolesQuery() { UserId = Id });
            return NewResult(response);
        }
        //  [HttpPost("Edit")]
        //public async Task<IActionResult> Edit([FromForm] EditRoleCommand command)
        //{
        //    var response = await Mediator.Send(command);
        //    return NewResult(response);
        //}

        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete( int id)
        //{
        //    var response = await Mediator.Send(new DeleteRoleCommand(id));
        //    return NewResult(response);
        //}
        [HttpPut("UpdateUserRoles")]
        public async Task<IActionResult> UpdateUserRoles([FromBody] UpdateUserRolesCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpGet("ManageUserClaims")]
        public async Task<IActionResult> ManageUserClaims(int userId)
        {
            var response = await Mediator.Send(new ManageUserClaimsQuery(userId));
            return NewResult(response);
        }

        [HttpPut("UpdateUserClaims")]
        public async Task<IActionResult> UpdateUserClaims([FromBody] UpdateUserClaimsCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
    }
}
