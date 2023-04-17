using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Common;
using SocialBook.Persistence.Contexts;

namespace SocialBook.Persistence.Repositories.Common
{
    public class GenreWriteRepository : WriteRepository<Genre>, IGenreWriteRepository
    {
        public GenreWriteRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
