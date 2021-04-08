﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;
        private readonly UserManager<User> _userManager;

        public HomeController(ICategoryService categoryService, ICommentService commentService, IArticleService articleService, UserManager<User> userManager)
        {
            _categoryService = categoryService;
            _articleService = articleService;
            _commentService = commentService;
            _userManager = userManager;
        }

        [Authorize(Roles = "SuperAdmin,AdminArea.Home.Read")]
        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByNonDeletedAsync();
            var articlesCountResult = await _articleService.CountByNonDeletedAsync();
            var commentsCountResult = await _commentService.CountByNonDeletedAsync();
            var usersCountResult = await _userManager.Users.CountAsync();
            var articlesResult = await _articleService.GetAllByNotDeletedAsync();        
            if (categoriesCountResult.ResultStatus ==ResultStatus.Success && articlesCountResult.ResultStatus==ResultStatus.Success
                && commentsCountResult.ResultStatus==ResultStatus.Success &&usersCountResult>-1 &&articlesResult.ResultStatus==ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount=categoriesCountResult.Data,
                    ArticlesCount=articlesCountResult.Data,
                    CommentsCount=commentsCountResult.Data,
                    UsersCount=usersCountResult,
                    Articles = articlesResult.Data

                });
            }
            return NotFound();
        }


    }
}
