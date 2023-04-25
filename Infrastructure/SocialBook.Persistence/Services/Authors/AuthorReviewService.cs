using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewService : IAuthorReviewService
    {
        private readonly IAuthorReviewReadRepository _authorReviewReadRepository;
        private readonly IAuthorReviewWriteRepository _authorReviewWriteRepository;

        public AuthorReviewService(IAuthorReviewReadRepository authorReviewReadRepository, IAuthorReviewWriteRepository authorReviewWriteRepository)
        {
            _authorReviewReadRepository = authorReviewReadRepository;
            _authorReviewWriteRepository = authorReviewWriteRepository;
        }

        /// <summary>
        /// Get all author reviews matching the rating value provided as a parameter
        /// </summary>
        /// <param name="rating">The author review rating</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews matching the rating value provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating)
        {
            if (rating < 0) { throw new ArgumentNullException(nameof(rating)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByRatingAsync(rating);
        }

        /// <summary>
        /// Get author reviews belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByAuthorAsync(authorId);
        }

        /// <summary>
        /// Get author reviews belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByUserAsync(userId);
        }

        /// <summary>
        /// Create a new author review
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorReviewAsync(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return await _authorReviewWriteRepository.AddAsync(authorReview);
        }

        /// <summary>
        /// Update the author review provided as a parameter
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>A boolean value indicating whether the author review was updated successfully or not</returns>
        public bool UpdateAuthorReview(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return _authorReviewWriteRepository.Update(authorReview);
        }

        /// <summary>
        /// Delete the author review provided as a parameter
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>A boolean value indicating whether the author review was deleted successfully or not</returns>
        public bool DeleteAuthorReview(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return _authorReviewWriteRepository.Remove(authorReview);
        }
    }
}
