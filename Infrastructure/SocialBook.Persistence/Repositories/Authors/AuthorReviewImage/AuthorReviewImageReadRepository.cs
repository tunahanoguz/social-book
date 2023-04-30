using Microsoft.EntityFrameworkCore;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.FileExtension == fileExtension, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId, paginationFilter, false);
        }
    }
}
