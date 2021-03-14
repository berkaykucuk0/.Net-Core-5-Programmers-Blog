using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using NToastNotify;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly AboutUsPageInfo _aboutUsInfo;
        private readonly IMailService _mailService;
        private readonly IToastNotification _toastNotification;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageWriterInfo;
        public HomeController(IArticleService articleService, IOptionsSnapshot<AboutUsPageInfo> aboutUsInfo, IMailService mailService, IToastNotification toastNotification, IWritableOptions<AboutUsPageInfo> aboutUsPageWriterInfo)
        {
            _articleService = articleService;
            _aboutUsInfo = aboutUsInfo.Value;
            _mailService = mailService;
            _toastNotification = toastNotification;
            _aboutUsPageWriterInfo = aboutUsPageWriterInfo;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int ?categoryId)
        {
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByNotDeletedAndActiveAsync() : _articleService.GetAllByCategoryAsync(categoryId.Value));
           
            return View(articlesResult.Data);
        }

        [HttpGet]
        public IActionResult About()
        {
           
            return View(_aboutUsInfo);
        }

        [HttpGet]
        public IActionResult Contact()
        {

            return View();
        }

        public static List<string> GetErrorListFromModelState
                                              (ModelStateDictionary modelState)
        {
            var query = from state in modelState.Values
                        from error in state.Errors
                        select error.ErrorMessage;

            var errorList = query.ToList();
            return errorList;
        }

        [HttpPost]
        public IActionResult Contact(EmailSendDto emailSendDto)
        {
            if (ModelState.IsValid)
            {
                var result = _mailService.SendContactEmail(emailSendDto);
                _toastNotification.AddSuccessToastMessage(result.Message,new ToastrOptions {
                        Title ="Başarılı İşlem!"                
                });
                return View();
            }
           var list =  GetErrorListFromModelState(ModelState);
            return View(emailSendDto);
        }
    }
}
