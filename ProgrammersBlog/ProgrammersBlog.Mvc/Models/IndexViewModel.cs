using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Models
{
    public class IndexViewModel
    {
        public ArticleListDto ArticleListDto { get; set; }
        public CommentListDto CommentListDto { get; set; }
        public CategoryListDto CategoryListDto { get; set; }
        public UserListDto UserListDto { get; set; }
    }
}
