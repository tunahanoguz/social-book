using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string fileExtension, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.FileExtension == fileExtension, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorId == authorId, paginationFilter, false);
        }
    }
}
