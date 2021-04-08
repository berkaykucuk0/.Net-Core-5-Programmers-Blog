using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ProgrammersBlogContext _context;
        private readonly EfArticleRepository _efArticleRepository;
        private readonly EfCategoryRepository _efCategoryRepository;
        private readonly EfCommentRepository _efCommentRepository;
        private readonly EfContactRepository _efContactRepository;
        private readonly EfPageRepository _efPageRepository;

        public UnitOfWork(ProgrammersBlogContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _efArticleRepository ?? new EfArticleRepository(_context);


        public ICategoryRepository Categories => _efCategoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _efCommentRepository ?? new EfCommentRepository(_context);

        public IContactRepository Contact => _efContactRepository ?? new EfContactRepository(_context);

        public IPageRepository Pages => _efPageRepository ?? new EfPageRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
