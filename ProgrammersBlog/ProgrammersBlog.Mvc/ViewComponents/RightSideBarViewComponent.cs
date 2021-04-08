using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.ViewComponents
{
    public class RightSideBarViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService  _articleService;

        public RightSideBarViewComponent(ICategoryService categoryService, IArticleService articleService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesResult = await _categoryService.GetAllByNotDeletedAndActiveAsync();
            var articlesResult = await _articleService.GetAllViewCountAsync(isAscending:false,10);

            return View(new RightSiteBarViewModel
            {
                Categories = categoriesResult.Data.Category,
                Articles = articlesResult.Data.Articles
            });
        }
    }
}
