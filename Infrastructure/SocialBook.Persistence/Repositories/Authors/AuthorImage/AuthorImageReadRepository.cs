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

        /// <summary>
        /// Get all author images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images with the file extension provided as a parameter
        /// </returns>
        public async Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string fileExtension)
        {
            return await GetWhere(a => a.FileExtension == fileExtension).ToListAsync();
        }

        /// <summary>
        /// Get all author images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }
    }
}
