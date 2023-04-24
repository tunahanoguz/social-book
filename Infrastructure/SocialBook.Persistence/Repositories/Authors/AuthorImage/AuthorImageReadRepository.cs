using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorImageReadRepository : ReadRepository<AuthorImage>, IAuthorImageReadRepository
    {
        public AuthorImageReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        public async Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string fileExtension)
        {
            return await GetWhere(a => a.FileExtension == fileExtension).ToListAsync();
        }

        public async Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }
    }
}
