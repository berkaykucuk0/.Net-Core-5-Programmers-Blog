using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Models
{
    public class UserDetailViewModel
    {
        public User User { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public ArticleListDto MostViewedArticles { get; set; }
    }
}
