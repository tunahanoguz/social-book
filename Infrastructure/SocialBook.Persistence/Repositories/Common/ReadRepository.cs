using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Common;
using SocialBook.Persistence.Contexts;
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

        public IQueryable<T> GetAll(bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return query;
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

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTrackingEnabled = true)
        {
            var query = Table.AsQueryable();

            if (!isTrackingEnabled)
                query.AsNoTracking();

            return query.Where(expression);
        }
    }
}
