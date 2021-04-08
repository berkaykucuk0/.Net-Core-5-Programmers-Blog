using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IPageService 
    {
        Task<IDataResult<PageDto>> GetAsync(int pageId);
        Task<IDataResult<PageListDto>> GetAllAsync();
        Task<IDataResult<PageListDto>> GetAllByNotDeletedAsync();
        Task<IDataResult<PageListDto>> GetAllByNotDeletedAndActiveAsync();
        Task<IDataResult<PageUpdateDto>> GetPageUpdateDto(int pageId);

        //IResultlar
        Task<IResult> AddAsync(PageAddDto pageAddDto, string createdByName);
        Task<IResult> UpdateAsync(PageUpdateDto pageUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int pageId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int pageId);
    }
}
