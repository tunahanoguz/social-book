using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReviewImageReadRepository : ReadRepository<AuthorReviewImage>, IAuthorReviewImageReadRepository
    {
        public AuthorReviewImageReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension)
        {
            return await GetWhere(a => a.FileExtension == fileExtension).ToListAsync();
        }

        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId).ToListAsync();
        }
    }
}
