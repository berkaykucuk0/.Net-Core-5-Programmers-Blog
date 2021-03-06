using AutoMapper;
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
    public class CategoryManager :ManagerBase, ICategoryService
    {
        

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper): base(unitOfWork,mapper)
        {
           
        }
        
        public async Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = Mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;

            var addedCategory = await UnitOfWork.Categories.AddAsync(category);
            await UnitOfWork.SaveAsync();
            return new DataResult<CategoryDto>(ResultStatus.Success,Messages.Category.Add(categoryAddDto.Name), new CategoryDto 
            {           
                Category = addedCategory,
                ResultStatus= ResultStatus.Success,
                Message= Messages.Category.Add(categoryAddDto.Name)
            });
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var categoriesCount = await UnitOfWork.Categories.CountAsync();
            if (categoriesCount>-1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata oluştu!",-1);
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var categoriesCount = await UnitOfWork.Categories.CountAsync(c=>!c.IsDeleted);
            if (categoriesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata oluştu!", -1);
        }
      
        public async Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);

            if (category != null)
            {
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;

                var deletedCategory = await UnitOfWork.Categories.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.Delete(deletedCategory.Name), new CategoryDto
                {
                    Category = deletedCategory,
                    ResultStatus = ResultStatus.Success,
                    Message = Messages.Category.Delete(deletedCategory.Name)
                });
            }

            return new DataResult<CategoryDto>(ResultStatus.Success,Messages.Category.NotFound(isPlural:false), new CategoryDto
            {
                Category = null,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.NotFound(isPlural: false)
            });

        }
      
        public async Task<IDataResult<CategoryDto>> GetAsync(int categoryId)
        {
           var category=  await UnitOfWork.Categories.GetAsync(c=>c.Id==categoryId,c=>c.Articles);
            if (category!=null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success,new CategoryDto { 
                
                    Category= category,
                    ResultStatus=ResultStatus.Success

                });
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: false), new CategoryDto 
            {
                Category= null,
                ResultStatus=ResultStatus.Error,
                Message= Messages.Category.NotFound(isPlural: false)
            });
        }

        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(null);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {

                    Category = categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), new CategoryListDto
            {

                Category = null,
                ResultStatus = ResultStatus.Error,
                Message= Messages.Category.NotFound(isPlural: true)

            });
        }
      
        public async Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => c.IsDeleted == false);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {

                    Category = categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), new CategoryListDto
            {

                Category = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(isPlural: true)

            });
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAndActiveAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => c.IsDeleted == false && c.IsActive==true);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {

                    Category = categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), null);
        }
           
        public async Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId);
                var categoryUpdateDto = Mapper.Map<CategoryUpdateDto>(category);
                return new DataResult<CategoryUpdateDto>(ResultStatus.Success, categoryUpdateDto);
            }
            else
            {
                return new DataResult<CategoryUpdateDto>(ResultStatus.Error, Messages.Category.NotFound(isPlural: true), null);
            }
        }
       
        public async Task<IResult> HardDeleteAsync(int categoryId)
        {
            var category = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);

            if (category != null)
            {
                await UnitOfWork.Categories.DeleteAsync(category);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Category.HardDelete(category.Name));
            }
            return new Result(ResultStatus.Error,Messages.Category.NonDeleted());
        }
       
        public async Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var oldCategory = await UnitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            var category = Mapper.Map<CategoryUpdateDto,Category>(categoryUpdateDto,oldCategory);
            category.ModifiedByName = modifiedByName;
            var updatedCategory= await UnitOfWork.Categories.UpdateAsync(category);
            await UnitOfWork.SaveAsync();
            return new DataResult<CategoryDto>(ResultStatus.Success, Messages.Category.Update(categoryUpdateDto.Name), new CategoryDto 
            {
                Category = updatedCategory,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Category.Update(categoryUpdateDto.Name)
            });
        }
    }
}
