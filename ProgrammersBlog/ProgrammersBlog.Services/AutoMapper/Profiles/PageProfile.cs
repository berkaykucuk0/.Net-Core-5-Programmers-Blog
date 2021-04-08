using AutoMapper;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.AutoMapper.Profiles
{
    public class PageProfile:Profile
    {
        public PageProfile()
        {
            CreateMap<PageAddDto, Page>().ForMember(dest => dest.CreateDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<PageUpdateDto, Page>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now)); ;
            CreateMap<Page, PageUpdateDto>();
        }
    }
}
