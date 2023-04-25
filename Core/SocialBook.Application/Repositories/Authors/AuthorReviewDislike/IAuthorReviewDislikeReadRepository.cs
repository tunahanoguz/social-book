using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewDislikeReadRepository : IReadRepository<AuthorReviewDislike>
    {
        /// <summary>
        /// Get all author review dislikes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes for the author review with the given ID as a parameter
        /// </returns>
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId);

        /// <summary>
        /// Get all author review dislikes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId);
    }
}
