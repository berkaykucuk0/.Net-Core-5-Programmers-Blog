using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.IUtilites.Extensions;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Add(CommentAddDto commentAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _commentService.AddAsync(commentAddDto);
                if (result.ResultStatus==ResultStatus.Success)
                {
                    var commentAddAjaxViewModel =JsonSerializer.Serialize( new CommentAddAjaxViewModel
                    {
                         CommentDto = result.Data,
                         CommentAddPartial= await this.RenderViewToStringAsync("_CommentAddPartial"),
                            
                    },new JsonSerializerOptions
                    {
                       ReferenceHandler = ReferenceHandler.Preserve  
                    });
                    return Json(commentAddAjaxViewModel);
                }
                ModelState.AddModelError("", result.Message);
            }
            var commentAddAjaxModelStateErrorViewModel = JsonSerializer.Serialize(new CommentAddAjaxViewModel
            {
                CommentAddDto = commentAddDto,
                CommentAddPartial = await this.RenderViewToStringAsync("_CommentAddPartial"),

            });
            return Json(commentAddAjaxModelStateErrorViewModel);
        }
    }
}
