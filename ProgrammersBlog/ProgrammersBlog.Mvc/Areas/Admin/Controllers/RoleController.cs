using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Shared.IUtilites.Extensions;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : BaseController
    {
        private readonly RoleManager<Role> _roleManager;
        
        public RoleController(RoleManager<Role> roleManager,UserManager<User> userManager, IImageHelper imageHelper, IMapper mapper) :base(userManager,mapper,imageHelper)
        {
            _roleManager = roleManager;          
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin,Role.Read")]
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();

            return View(new RoleListDto
            {
                 Roles= roles                              
            });
        }

       
        [Authorize(Roles = "SuperAdmin,Role.Read")]
        [HttpGet]
        public async Task<JsonResult> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleListDto = JsonSerializer.Serialize(new RoleListDto
            {
               Roles=roles,
            
            });
            return Json(roleListDto);
        }

        [Authorize(Roles = "SuperAdmin,User.Update")]
        [HttpGet]
        public async Task<IActionResult> Assign(int userId)
        {

            var roles = await _roleManager.Roles.ToListAsync();
            var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
            var userRoles = await UserManager.GetRolesAsync(user);
            UserRoleAssignDto userRoleAssignDto = new UserRoleAssignDto
            {
                UserId = user.Id,
                UserName = user.UserName,                
            };

            foreach (var role in roles)
            {
                RoleAssignDto roleAssignDto = new RoleAssignDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    HasRole = userRoles.Contains(role.Name)
                };
                userRoleAssignDto.RoleAssignDtos.Add(roleAssignDto);
            }
            return PartialView("_RoleAssignPartial",userRoleAssignDto);
        }


        [Authorize(Roles = "SuperAdmin,User.Update")]
        [HttpPost]
        public async Task<IActionResult> Assign(UserRoleAssignDto  userRoleAssignDto)
        {

            if (ModelState.IsValid)
            {
                var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userRoleAssignDto.UserId);
                foreach (var roleAssignDto in userRoleAssignDto.RoleAssignDtos)
                {
                    if (roleAssignDto.HasRole)
                    {
                        await UserManager.AddToRoleAsync(user, roleAssignDto.RoleName);
                    }
                    else
                    {
                        await UserManager.RemoveFromRoleAsync(user, roleAssignDto.RoleName);
                    }
                }
                await UserManager.UpdateSecurityStampAsync(user);
                var userRoleAssignAjaxViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                     UserDto= new UserDto
                     {
                          User=user,
                          Message=$"{user.UserName} kullanıcısına rol atama başarıyla tamamlanmıştır",
                          ResultStatus=ResultStatus.Success
                     },
                      RoleAssignPartial= await this.RenderViewToStringAsync("_RoleAssignPartial",userRoleAssignDto)                   
                });
                return Json(userRoleAssignAjaxViewModel);
            }
            if (true)
            {
                var userRoleAssignAjaxErrorViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                    
                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto),
                    UserRoleAssignDto= userRoleAssignDto
                });
                return Json(userRoleAssignAjaxErrorViewModel);
            }
        }

    }
}
