using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Utilities;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using ProgrammersBlog.Shared.IUtilites.Results.Concrede;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class PageManager : ManagerBase, IPageService
    {
        private readonly UserManager<User> _userManager;
        public PageManager(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager) : base(unitOfWork, mapper)
        {
            _userManager = userManager;
        }

        public async Task<IResult> AddAsync(PageAddDto pageAddDto, string createdByName)
        {
            var page = Mapper.Map<Page>(pageAddDto);
            page.CreatedByName = createdByName;
            page.ModifiedByName = createdByName;                   
            await UnitOfWork.Pages.AddAsync(page);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Page.Add(page.Title));
        }

        public async Task<IResult> DeleteAsync(int pageId, string modifiedByName)
        {
            var result = await UnitOfWork.Pages.AnyAsync(p => p.Id == pageId);
            if (result)
            {
                var page = await UnitOfWork.Pages.GetAsync(p => p.Id == pageId);
                page.IsDeleted = true;
                page.IsActive = false;
                page.ModifiedByName = modifiedByName;
                page.ModifiedDate = DateTime.Now;

                await UnitOfWork.Pages.UpdateAsync(page);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Page.Delete(page.Title));
            }
            return new Result(ResultStatus.Success, Messages.Page.NonDeleted());
        }

        public async Task<IDataResult<PageListDto>> GetAllAsync()
        {
            var pages = await UnitOfWork.Pages.GetAllAsync(null);
            if (pages.Count > -1)
            {
                return new DataResult<PageListDto>(ResultStatus.Success, new PageListDto
                {
                    Pages = pages,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<PageListDto>(ResultStatus.Error, Messages.Page.NonDeleted(), null);
        }

        public async Task<IDataResult<PageListDto>> GetAllByNotDeletedAndActiveAsync()
        {
            var pages = await UnitOfWork.Pages.GetAllAsync(p=>p.IsDeleted==false && p.IsActive==true);
            if (pages.Count > -1)
            {
                return new DataResult<PageListDto>(ResultStatus.Success, new PageListDto
                {
                    Pages = pages,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<PageListDto>(ResultStatus.Error, Messages.Page.NonDeleted(), null);
        }

        public async Task<IDataResult<PageListDto>> GetAllByNotDeletedAsync()
        {
            var pages = await UnitOfWork.Pages.GetAllAsync(p => p.IsDeleted == false);
            if (pages.Count > -1)
            {
                return new DataResult<PageListDto>(ResultStatus.Success, new PageListDto
                {
                    Pages = pages,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<PageListDto>(ResultStatus.Error, Messages.Page.NonDeleted(), null);
        }

        public async Task<IDataResult<PageDto>> GetAsync(int pageId)
        {
            var page = await UnitOfWork.Pages.GetAsync(p => p.Id == pageId);

            if (page != null)
            {              
                return new DataResult<PageDto>(ResultStatus.Success, new PageDto
                {
                    Page = page,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PageDto>(ResultStatus.Error, Messages.Page.NonDeleted(), null);
        }

        public async Task<IDataResult<PageUpdateDto>> GetPageUpdateDto(int pageId)
        {
            var result = await UnitOfWork.Pages.AnyAsync(p => p.Id == pageId);
            if (result)
            {
                var page = await UnitOfWork.Pages.GetAsync(p => p.Id == pageId);
                var pageUpdateDto = Mapper.Map<PageUpdateDto>(page);
                return new DataResult<PageUpdateDto>(ResultStatus.Success, pageUpdateDto);
            }
            return new DataResult<PageUpdateDto>(ResultStatus.Error, null);
        }

        public async Task<IResult> HardDeleteAsync(int pageId)
        {
            var result = await UnitOfWork.Pages.AnyAsync(p => p.Id == pageId);
            if (result)
            {
                var page = await UnitOfWork.Pages.GetAsync(p => p.Id == pageId);

                await UnitOfWork.Pages.DeleteAsync(page);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Page.HardDelete(page.Title));
            }
            return new Result(ResultStatus.Error, Messages.Page.NonDeleted());
        }

        public async Task<IResult> UpdateAsync(PageUpdateDto pageUpdateDto, string modifiedByName)
        {
            var oldPage = await UnitOfWork.Pages.GetAsync(p => p.Id == pageUpdateDto.Id);
            var page = Mapper.Map<PageUpdateDto, Page>(pageUpdateDto, oldPage);
            page.ModifiedByName = modifiedByName;           
            await UnitOfWork.Pages.UpdateAsync(page);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Page.Update(page.Title));
        }
    }
}
