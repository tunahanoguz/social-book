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

        /// <summary>
        /// Get all author review images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images with the file extension provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension)
        {
            return await GetWhere(a => a.FileExtension == fileExtension).ToListAsync();
        }

        /// <summary>
        /// Get all author review images belonging to the author review whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images belonging to the author review whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId).ToListAsync();
        }
    }
}
