using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.ComplexTypes;
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class ArticleManager :ManagerBase, IArticleService
    {
        private readonly UserManager<User> _userManager;

        public ArticleManager(IUnitOfWork unitOfWork , IMapper mapper, UserManager<User> userManager) :base(unitOfWork,mapper)
        {
            _userManager = userManager;
        }

        public async Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createdByName,int userId)
        {
            var article = Mapper.Map<Article>(articleAddDto);
            article.CreatedByName = createdByName;
            article.ModifiedByName = createdByName;
            article.UserId = userId;
            await UnitOfWork.Articles.AddAsync(article);
            await UnitOfWork.SaveAsync();
            return new  Result(ResultStatus.Success, Messages.Article.Add(article.Title));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var articlesCount = await UnitOfWork.Articles.CountAsync();
            if (articlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, articlesCount);
            }
            return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata oluştu!", -1);
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var articlesCount = await UnitOfWork.Articles.CountAsync(c=>!c.IsDeleted);
            if (articlesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, articlesCount);
            }
            return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata oluştu!", -1);
        }

        public async Task<IResult> DeleteAsync(int articleId, string modifiedByName)
        {
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
                article.IsDeleted = true;
                article.IsActive = false;
                article.ModifiedByName = modifiedByName;
                article.ModifiedDate = DateTime.Now;

              await UnitOfWork.Articles.UpdateAsync(article);
              await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Article.Delete(article.Title));
            }
            return new Result(ResultStatus.Success, Messages.Article.NonDeleted());
        }

        public async Task<IDataResult<ArticleDto>> GetAsync(int articleId)
        {
            var article = await UnitOfWork.Articles.GetAsync(c => c.Id == articleId, c => c.User,c=>c.Category);
          
            if (article!=null)
            {
                article.Comments = await  UnitOfWork.Comments.GetAllAsync(c => c.ArticleId == articleId && !c.IsDeleted && c.IsActive);
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article=article,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error, Messages.Article.NonDeleted(), null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(null, c => c.User, c => c.Category);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NonDeleted(), null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByUserAsync(int userId,int takeSize)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user!=null)
            {
                var articles = await UnitOfWork.Articles.GetAllAsync(u=>u.UserId==user.Id && u.IsDeleted==false &&u.IsActive==true, c => c.User, c => c.Category);
                if (articles.Count>-1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                         Articles=articles,
                         ResultStatus=ResultStatus.Success,
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural: true), null);
            }
            else
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByUserAndViewCountAsync(int userId, int takeSize)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                var articles = await UnitOfWork.Articles.GetAllAsync(u => u.UserId == userId && u.IsDeleted == false && u.IsActive == true,
                    c => c.User, c => c.Category);               
                    var sortedArticles = articles.Take(takeSize).OrderByDescending(a => a.ViewsCount).ToList();
                if (sortedArticles.Count>=-1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = sortedArticles,
                        ResultStatus = ResultStatus.Success,
                    });
                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural: true), null);
            }
            else
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByCategoryAsync(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result==true)
            {
                var articles = await UnitOfWork.Articles.GetAllAsync(c => c.CategoryId == categoryId && c.IsDeleted == false && c.IsActive == true, c => c.User, c => c.Category);

                if (articles.Count > -1)
                {
                    return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                    {
                        Articles = articles,
                        ResultStatus = ResultStatus.Success
                    });

                }
                return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural:false), null);
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NotFound(isPlural: false), null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNotDeletedAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(c => c.IsDeleted == false, c => c.User, c => c.Category);

            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NonDeleted(), null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNotDeletedAndActiveAsync()
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(c => c.IsDeleted == false && c.IsActive == true, c => c.User, c => c.Category);

            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, Messages.Article.NonDeleted(), null);
        }

        public async Task<IResult> HardDeleteAsync(int articleId)
        {
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);

                await UnitOfWork.Articles.DeleteAsync(article);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Article.HardDelete(article.Title));
            }
            return new Result(ResultStatus.Error, Messages.Article.NonDeleted());
        }

        public async Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            var oldArticle = await UnitOfWork.Articles.GetAsync(a => a.Id == articleUpdateDto.Id);
            var article = Mapper.Map<ArticleUpdateDto,Article>(articleUpdateDto,oldArticle);
            article.ModifiedByName = modifiedByName;
            article.UserId = 1;
            await UnitOfWork.Articles.UpdateAsync(article);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Article.Update(article.Title));
        }

        public async Task<IDataResult<ArticleUpdateDto>> GetArticleUpdateDtoAsync(int articleId)
        {
             
            var result = await UnitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
                var articleUpdateDto = Mapper.Map<ArticleUpdateDto>(article);
                return new DataResult<ArticleUpdateDto>(ResultStatus.Success, articleUpdateDto);
            }
            else
            {
                return new DataResult<ArticleUpdateDto>(ResultStatus.Error,Messages.Article.NotFound(isPlural:false), null);
            }
        }

        public async Task<IDataResult<ArticleListDto>> GetAllViewCountAsync(bool isAscending, int? takeSize)
        {
            var articles = await UnitOfWork.Articles.GetAllAsync(a=>a.IsActive==true &&a.IsDeleted==false , a=>a.User ,a=>a.Category);
            var sortedArticles = isAscending ? articles.OrderBy(a => a.ViewsCount) : articles.OrderByDescending(a => a.ViewsCount);
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto { 
                  Articles = takeSize == null ? sortedArticles.ToList() : sortedArticles.Take(takeSize.Value).ToList()
            });
        }

        public async Task<IDataResult<ArticleListDto>> SearchAsync(string keyword, bool isAscending = false)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                var articles = await UnitOfWork.Articles.GetAllAsync(a => a.IsActive == true && a.IsDeleted == false, a => a.User, a => a.Category);
                var sortedArticles = isAscending ? articles.OrderBy(a => a.Date) : articles.OrderByDescending(a => a.Date);
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = sortedArticles.ToList()
                });
            }
            else
            {
                var searchedArticle = await UnitOfWork.Articles.SearchAsync(new List<Expression<Func<Article, bool>>> {
                    (a)=>a.Title.Contains(keyword),
                    (a)=>a.Category.Name.Contains(keyword),
                    (a)=>a.SeoDescription.Contains(keyword),
                    (a)=>a.SeoTags.Contains(keyword),
                    (a)=>a.SeoAuthor.Contains(keyword),
                    
                }, a=>a.Category, a=>a.User);

                var searchedAndSortedArticles = isAscending ? searchedArticle.OrderBy(a => a.Date) : searchedArticle.OrderByDescending(a => a.Date);
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = searchedArticle.ToList()
                });
            }
        }

        public async Task<IResult> IncreaseViewCountAsync(int articleId)
        {
            var article = await UnitOfWork.Articles.GetAsync(a => a.Id == articleId);
            if (article==null)
            {
                return new Result(ResultStatus.Error,Messages.Article.NotFound(isPlural:false));
            }
            article.ViewsCount += 1;
            await UnitOfWork.Articles.UpdateAsync(article);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Article.IncreaseViewCount());
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByUserIdOnFilter(int userId, FilterBy filterBy, OrderBy orderBy, 
        bool isAscending, int takeSize, int categoryId, DateTime startAt, DateTime endAt, int minViewCount, int maxViewCount, int minCommentCount, int maxCommentCount)
        {
            var anyUser = await _userManager.Users.AnyAsync(u => u.Id == userId);
            if (!anyUser)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Error, $"{userId} id li kullanıcı bulunamadı", null);
            }
            var userArticles = await UnitOfWork.Articles.GetAllAsync(a=>a.IsActive &&!a.IsDeleted && a.UserId==userId);
            var sortedArticles = new List<Article>();
            switch (filterBy)
            {
                case FilterBy.Category:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                             sortedArticles = isAscending ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                                .OrderBy(a => a.Date).ToList() : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                                .OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                             sortedArticles = isAscending ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                               .OrderBy(a => a.ViewsCount).ToList() : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                               .OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                               .OrderBy(a => a.CommentsCount).ToList() : userArticles.Where(a => a.CategoryId == categoryId).Take(takeSize)
                               .OrderByDescending(a => a.CommentsCount).ToList();
                            break;
                        
                    }
                    break;
                case FilterBy.Date:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending ? userArticles.Where(a => a.Date >= startAt && a.Date<=endAt).Take(takeSize)
                               .OrderBy(a => a.Date).ToList() : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize)
                               .OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize)
                              .OrderBy(a => a.ViewsCount).ToList() : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize)
                              .OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize)
                               .OrderBy(a => a.CommentsCount).ToList() : userArticles.Where(a => a.Date >= startAt && a.Date <= endAt).Take(takeSize)
                               .OrderByDescending(a => a.CommentsCount).ToList();
                            break;

                    }
                    break;
                case FilterBy.ViewCount:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                               .OrderBy(a => a.Date).ToList() : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                               .OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                              .OrderBy(a => a.ViewsCount).ToList() : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                              .OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                               .OrderBy(a => a.CommentsCount).ToList() : userArticles.Where(a => a.ViewsCount >= minViewCount && a.ViewsCount <= maxViewCount).Take(takeSize)
                               .OrderByDescending(a => a.CommentsCount).ToList();
                            break;

                    }
                    break;
                case FilterBy.CommentCount:
                    switch (orderBy)
                    {
                        case OrderBy.Date:
                            sortedArticles = isAscending ? userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                               .OrderBy(a => a.Date).ToList() : userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                               .OrderByDescending(a => a.Date).ToList();
                            break;
                        case OrderBy.ViewCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                              .OrderBy(a => a.ViewsCount).ToList() : userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                              .OrderByDescending(a => a.ViewsCount).ToList();
                            break;
                        case OrderBy.CommentCount:
                            sortedArticles = isAscending ? userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                               .OrderBy(a => a.CommentsCount).ToList() : userArticles.Where(a => a.CommentsCount >= minCommentCount && a.ViewsCount <= maxCommentCount).Take(takeSize)
                               .OrderByDescending(a => a.CommentsCount).ToList();
                            break;
                    }
                    break;             
            }
            return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
            {
                Articles = sortedArticles
            });
        }

        
    }
}
