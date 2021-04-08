using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class UserController:Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IArticleService _articleService;
        public UserController(UserManager<User> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var articles = await _articleService.GetAllByUserAsync(userId,10);
            var sortedArticles = await _articleService.GetAllByUserAndViewCountAsync(userId, 4);

            if (user!=null)
            {
                return View(new UserDetailViewModel
                {
                     User= user,
                     ArticleListDto =articles.Data,
                     MostViewedArticles =sortedArticles.Data
                });
            }
            else
            {
                return NotFound();
            }
        
        }
    }
}
