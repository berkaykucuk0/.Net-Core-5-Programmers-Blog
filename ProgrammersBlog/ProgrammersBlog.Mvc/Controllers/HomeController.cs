using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NToastNotify;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using ProgrammersBlog.Shared.Utilities.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly AboutUsPageInfo _aboutUsInfo;
        private readonly IArticleService _articleService;
        private readonly IMailService _mailService;
        private readonly IToastNotification _toastNotification;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageWriterInfo;
        private readonly ICommentService _commentService;
        private readonly ICategoryService _categoryService;
        private readonly IContactService _contactService;
        public HomeController(IArticleService articleService, IOptionsSnapshot<AboutUsPageInfo> aboutUsInfo, IMailService mailService, IToastNotification toastNotification, IWritableOptions<AboutUsPageInfo> aboutUsPageWriterInfo, ICommentService commentService, ICategoryService categoryService, IContactService contactService, UserManager<User> userManager)
        {
            _articleService = articleService;
            _aboutUsInfo = aboutUsInfo.Value;
            _mailService = mailService;
            _toastNotification = toastNotification;
            _aboutUsPageWriterInfo = aboutUsPageWriterInfo;
            _commentService = commentService;
            _categoryService = categoryService;
            _contactService = contactService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int ?categoryId)
        {
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByNotDeletedAndActiveAsync() : _articleService.GetAllByCategoryAsync(categoryId.Value));
            var commentsResult = await _commentService.GetAllByNonDeletedAndActiveAsync();
            var categoriesResult = await _categoryService.GetAllByNotDeletedAndActiveAsync();
            var users = await _userManager.Users.ToListAsync();
            
            return View(new IndexViewModel {
              ArticleListDto =articlesResult.Data,
              CommentListDto =commentsResult.Data,
              CategoryListDto=categoriesResult.Data,
              UserListDto = new UserListDto
              {
                   Users=users,
                   ResultStatus=ResultStatus.Success
              }
            });
        }

        [HttpGet]
        public IActionResult About()
        {
           
            return View(_aboutUsInfo);
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var contactInfoResult = await _contactService.GetAsync(1);

            return View(new ContactViewModel {
                 ContactDto = contactInfoResult.Data
            });
        }

        [HttpPost]
        public async Task<IActionResult> Contact(EmailSendDto emailSendDto)
        {
            var contactInfoResult = await _contactService.GetAsync(1);

            if (ModelState.IsValid)
            {
                var result = _mailService.SendContactEmail(emailSendDto);
                _toastNotification.AddSuccessToastMessage(result.Message,new ToastrOptions {
                        Title ="Başarılı İşlem!"                
                });
                return View(new ContactViewModel
                {
                    ContactDto = contactInfoResult.Data                  
                });
            }
         
            return View(new ContactViewModel
            {
                ContactDto = contactInfoResult.Data,
                EmailSendDto=emailSendDto
            });
        }
    }
}
