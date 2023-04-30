using Microsoft.EntityFrameworkCore;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Common;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Extensions;
using System.Linq.Expressions;

namespace SocialBook.Persistence.Repositories.Common
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SocialBookAPIDbContext _context;

        public ReadRepository(SocialBookAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<PaginatedListDto<T>> GetAll(PaginationFilter paginationFilter, bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return await query.ToPaginatedList(paginationFilter);
        }

        public async Task<T> GetByIdAsync(string id, bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync(m => m.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task<PaginatedListDto<T>> GetWhere(Expression<Func<T, bool>> expression, PaginationFilter paginationFilter, bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return await query.Where(expression).ToPaginatedList(paginationFilter);
        }
    }
}
