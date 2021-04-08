using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Services.Abstract;
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
    [Authorize]
    public class PageController : BaseController
    {
        private readonly IPageService _pageService;
        private readonly IToastNotification _toastNotification;
        public PageController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IPageService pageService, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _pageService = pageService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = "SuperAdmin,Page.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _pageService.GetAllByNotDeletedAndActiveAsync();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = "SuperAdmin,Page.Read")]
        [HttpGet]
        public async Task<JsonResult> GetAllPages()
        {
            var result = await _pageService.GetAllByNotDeletedAsync();
            var pages = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(pages);
        }

        [Authorize(Roles = "SuperAdmin,Page.Create")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin,Page.Create")]
        [HttpPost]
        public async Task<IActionResult> Add(PageAddDto pageAddDto)
        {
            if (ModelState.IsValid)
            {
                var imageResult = await ImageHelper.UploadImage(pageAddDto.Title, pageAddDto.PictureFile, PictureType.Post);
                pageAddDto.Thumbnail = imageResult.Data.FullName;
                var result = await _pageService.AddAsync(pageAddDto, LoggedInUser.UserName);
                if (result.ResultStatus==ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return RedirectToAction("Index", "Page");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);                   
                }
            }          
                return View(pageAddDto);           
        }

        [Authorize(Roles = "SuperAdmin,Page.Update")]
        [HttpGet]
        public async Task <IActionResult> Update(int pageId)
        {
            var page = await _pageService.GetPageUpdateDto(pageId);
            if (page.ResultStatus==ResultStatus.Success)
            {
                return View(page.Data);
            }
            else
            {
                return NotFound();
            }         
        }
        [Authorize(Roles = "SuperAdmin,Page.Update")]
        [HttpPost]
        public async Task<IActionResult> Update(PageUpdateDto pageUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewThumbnailUploaded = false;
                var oldThumnail = pageUpdateDto.Thumbnail;
                if (pageUpdateDto.PictureFile != null)
                {
                    var uploadedImageResult = await ImageHelper.UploadImage(pageUpdateDto.Title, pageUpdateDto.PictureFile, PictureType.Post);
                    pageUpdateDto.Thumbnail = uploadedImageResult.ResultStatus == ResultStatus.Success ? uploadedImageResult.Data.FullName : "pageImages/defaultPage.png";
                    if (oldThumnail != "pageImages/defaultPage.png")
                    {
                        isNewThumbnailUploaded = true;
                    }
                }

                var result = await _pageService.UpdateAsync(pageUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewThumbnailUploaded)
                    {
                        ImageHelper.Delete(oldThumnail);
                    }
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return RedirectToAction("Index", "Page");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }
            return View(pageUpdateDto);

        }

        [Authorize(Roles = "SuperAdmin,Page.Delete")]
        [HttpPost]
        public async Task<JsonResult> Delete(int pageId)
        {
            var result = await _pageService.DeleteAsync(pageId, LoggedInUser.UserName);
            var deletedPage = JsonSerializer.Serialize(result);
            return Json(deletedPage);
        }

    }
}
