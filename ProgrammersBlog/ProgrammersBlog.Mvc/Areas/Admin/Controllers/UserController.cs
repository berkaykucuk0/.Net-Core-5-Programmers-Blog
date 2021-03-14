using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Shared.IUtilites.Extensions;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : BaseController
    {
       
        private readonly SignInManager<User> _signInManager;       
        private readonly IToastNotification _toastNotification;
        public UserController(UserManager<User> usermanager, IMapper mapper, SignInManager<User> signInManager, IImageHelper imageHelper, IToastNotification toastNotification)
            :base(usermanager,mapper,imageHelper)
        {          
            _signInManager = signInManager;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles="SuperAdmin,User.Read")]
        public async Task<IActionResult> Index()
        {
            var users = await UserManager.Users.ToListAsync();

            return View(new UserListDto 
            {
                    Users = users,
                    ResultStatus=ResultStatus.Success
            });
        }

        [Authorize(Roles = "SuperAdmin,User.Read")]
        [HttpGet]
        public async Task<JsonResult> GetAllUsers()
        {
            var users = await UserManager.Users.ToListAsync();
            var userListDto =JsonSerializer.Serialize( new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            }, new JsonSerializerOptions 
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return Json(userListDto);
        }


        [Authorize(Roles = "SuperAdmin,User.Create")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_UserAddPartial");
        }

        [Authorize(Roles = "SuperAdmin,User.Create")]
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            if (ModelState.IsValid)
            {
                var uploadedImageHelper = await ImageHelper.UploadImage(userAddDto.UserName,userAddDto.PictureFile,PictureType.User);
                userAddDto.Picture = uploadedImageHelper.ResultStatus == ResultStatus.Success
                    ? uploadedImageHelper.Data.FullName
                    : "userImages/defaultUser.png";
                var user = Mapper.Map<User>(userAddDto);
                var result = await UserManager.CreateAsync(user, userAddDto.Password);
                if (result.Succeeded)
                {
                    var userAjaxViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                             User= user,
                            ResultStatus = ResultStatus.Success,
                            Message = $"{user.UserName} kullanıcı adına sahip kullanıcı başarıyla eklenmiştir"
                        },
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto)

                    });
                    return Json(userAjaxViewModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var userAjaxErrorModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserAddDto = userAddDto,
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto)

                    });
                    return Json(userAjaxErrorModel);
                }

            }
            var userAjaxModelStateErrorModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
            {
                UserAddDto = userAddDto,
                UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto)

            });
            return Json(userAjaxModelStateErrorModel);
        }

        [Authorize(Roles = "SuperAdmin,User.Delete")]
        [HttpPost]
        public async Task<JsonResult> Delete(int userId)
        {
            var user = await UserManager.FindByIdAsync(userId.ToString());
            var result = await UserManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                if (user.Picture != "userImages/DefaultUser.png")
                {
                    ImageHelper.Delete(user.Picture);
                }

                var deletedUser = JsonSerializer.Serialize(new UserDto{
                   ResultStatus= ResultStatus.Success,
                   User = user,
                   Message="Başarıyla Silindi"
                });

                return Json(deletedUser);
            }
            else
            {
                string errorMessages = string.Empty;
                foreach (var error in result.Errors)
                {
                    errorMessages = $"*{error.Description}\n";

                }
                var deletedErrorUser = JsonSerializer.Serialize(new UserDto
                {
                    ResultStatus = ResultStatus.Error,
                    User = user,
                    Message = $"Silinirken Hata Oluştu!.Hatalar:\n {errorMessages}"
                });

                return Json(deletedErrorUser);
            }

          
        }
       
        [Authorize(Roles = "SuperAdmin,User.Update")]
        [HttpGet]
        public async Task<PartialViewResult> Update(int userId)
        {
            var user = await UserManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            var userUpdateDto = Mapper.Map<UserUpdateDto>(user);
            return PartialView("_UserUpdatePartial", userUpdateDto);
        }

        [Authorize(Roles = "SuperAdmin,User.Update")]
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldUser = await UserManager.FindByIdAsync(userUpdateDto.Id.ToString());
                var olduUserPicture = oldUser.Picture;
                if (userUpdateDto.PictureFile!=null)
                {
                    var uploadedImageHelper = await ImageHelper.UploadImage(userUpdateDto.UserName, userUpdateDto.PictureFile,PictureType.User);
                    userUpdateDto.Picture = uploadedImageHelper.ResultStatus == ResultStatus.Success
                        ? uploadedImageHelper.Data.FullName
                        : "userImages/defaultUser.png";
                    if (olduUserPicture != "userImages/defaultUser.png")
                    {
                        isNewPictureUploaded = true;
                    }
                  
                }
                var updatedUser = Mapper.Map<UserUpdateDto, User>(userUpdateDto, oldUser);
                var result =await UserManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageHelper.Delete(olduUserPicture);
                    }
                    var userUpdateAjaxViewModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                            ResultStatus = ResultStatus.Success,
                            Message = $"{updatedUser.UserName} adlı kullanıcı başarıyla güncellenmiştir.",
                            User = updatedUser
                        },
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)
                    });
                    return Json(userUpdateAjaxViewModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var userUpdateAjaxErrorModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                    {
                        UserUpdateDto = userUpdateDto,
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)

                    });
                    return Json(userUpdateAjaxErrorModel);
                }
            }
            else
            {
               
                var userUpdateAjaxModelStateErrorModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                {
                    UserUpdateDto = userUpdateDto,
                    UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdatePartial", userUpdateDto)

                });
                return Json(userUpdateAjaxModelStateErrorModel);
            }
           
        }

        [Authorize]
        [HttpGet]
        public async Task<ViewResult> ChangeDetails()
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var updateDto = Mapper.Map<UserUpdateDto>(user);
            return View(updateDto);
        }

        [Authorize]
        [HttpPost]
        public async Task<ViewResult> ChangeDetails(UserUpdateDto userUpdateDto )
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldUser = await UserManager.GetUserAsync(HttpContext.User);
                var olduUserPicture = oldUser.Picture;
                if (userUpdateDto.PictureFile != null)
                {
                    var uploadedImageHelper = await ImageHelper.UploadImage(userUpdateDto.UserName, userUpdateDto.PictureFile,PictureType.User);
                    userUpdateDto.Picture = uploadedImageHelper.ResultStatus == ResultStatus.Success
                        ? uploadedImageHelper.Data.FullName
                        : "userImages/defaultUser.png";
                    if (olduUserPicture != "userImages/defaultUser.png")
                    {
                        isNewPictureUploaded = true;
                    }                  
                }
                var updatedUser = Mapper.Map<UserUpdateDto, User>(userUpdateDto, oldUser);
                var result = await UserManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageHelper.Delete(olduUserPicture);
                    }

                    _toastNotification.AddSuccessToastMessage($"{updatedUser.UserName} adlı kullanıcı başarıyla güncellenmiştir.", new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return View(userUpdateDto);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(userUpdateDto);
                }
            }
            else
            {
                return View(userUpdateDto); 
            }
        }

        [HttpGet]
        [Authorize]
        public ViewResult PasswordChange()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<ViewResult> PasswordChange(UserPasswordChangeDto userPasswordChangeDto)
        {

            if (ModelState.IsValid)
            {
                var user = await UserManager.GetUserAsync(HttpContext.User);
                var isVerified = await UserManager.CheckPasswordAsync(user, userPasswordChangeDto.CurrentPassword);
                if (isVerified)
                {
                    var result = await UserManager.ChangePasswordAsync(user, userPasswordChangeDto.CurrentPassword, userPasswordChangeDto.NewPassword);
                    if (result.Succeeded)
                    {
                        await UserManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, userPasswordChangeDto.NewPassword,true,false);
                        _toastNotification.AddSuccessToastMessage($"Şifreniz başarıyla değiştirilmiştir.", new ToastrOptions { 
                            Title ="Başarılı İşlem"
                        });
                        return View();
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(userPasswordChangeDto);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen girmiş olduğunuz şifrenizi tekrar kontrol ediniz.");
                    return View(userPasswordChangeDto);
                }
               
            }
            else
            {
                ModelState.AddModelError("", "Lütfen girmiş olduğunuz şifrenizi tekrar kontrol ediniz.");
                return View(userPasswordChangeDto);
            }
          
        }

        [Authorize(Roles = "SuperAdmin,User.Read")]
        [HttpGet]
        public async Task<PartialViewResult> GetDetail(int userId)
        {
            var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
            return PartialView("_GetDetailPartial", new UserDto { User = user });
        }

        [HttpGet]
        public ViewResult AccessDenied()
        {
            return View();
        }



    }
}
