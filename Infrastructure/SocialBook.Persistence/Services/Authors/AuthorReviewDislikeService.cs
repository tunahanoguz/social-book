using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewDislikeService : IAuthorReviewDislikeService
    {
        private readonly IAuthorReviewDislikeReadRepository _authorReviewDislikeReadRepository;
        private readonly IAuthorReviewDislikeWriteRepository _authorReviewDislikeWriteRepository;

        public AuthorReviewDislikeService(IAuthorReviewDislikeReadRepository authorReviewDislikeReadRepository,
            IAuthorReviewDislikeWriteRepository authorReviewDislikeWriteRepository)
        {
            _authorReviewDislikeReadRepository = authorReviewDislikeReadRepository;
            _authorReviewDislikeWriteRepository = authorReviewDislikeWriteRepository;
        }

        /// <summary>
        /// Get all author review dislikes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes for the author review with the given ID as a parameter
        /// </returns>
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentException(nameof(authorReviewId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByAuthorReviewAsync(authorReviewId);
        }

        /// <summary>
        /// Get all author review dislikes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByUserAsync(userId);
        }

        /// <summary>
        /// Create a new author review dislike
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review dislike was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return await _authorReviewDislikeWriteRepository.AddAsync(authorReviewDislike);
        }

        /// <summary>
        /// Update the author review dislike provided as a parameter
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>A boolean value indicating whether the author review dislike was updated successfully or not</returns>
        public bool UpdateAuthorReviewDislike(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return _authorReviewDislikeWriteRepository.Update(authorReviewDislike);
        }

        /// <summary>
        /// Delete the author review dislike provided as a parameter
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>A boolean value indicating whether the author review dislike was deleted successfully or not</returns>
        public bool DeleteAuthorReviewDislike(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return _authorReviewDislikeWriteRepository.Remove(authorReviewDislike);
        }
    }
}
