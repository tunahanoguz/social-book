using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewLikeService : IAuthorReviewLikeService
    {
        private readonly IAuthorReviewLikeReadRepository _authorReviewLikeReadRepository;
        private readonly IAuthorReviewLikeWriteRepository _authorReviewLikeWriteRepository;

        public AuthorReviewLikeService(IAuthorReviewLikeReadRepository authorReviewLikeReadRepository, IAuthorReviewLikeWriteRepository authorReviewLikeWriteRepository)
        {
            _authorReviewLikeReadRepository = authorReviewLikeReadRepository;
            _authorReviewLikeWriteRepository = authorReviewLikeWriteRepository;
        }

        /// <summary>
        /// Get all author review likes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes for the author review with the given ID as a parameter
        /// </returns>
        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByAuthorReviewAsync(authorReviewId);
        }

        /// <summary>
        /// Get all author review likes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByUserAsync(userId);
        }

        /// <summary>
        /// Create a new author review like
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review like was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return await _authorReviewLikeWriteRepository.AddAsync(authorReviewLike);
        }

        /// <summary>
        /// Update the author review like provided as a parameter
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>A boolean value indicating whether the author review like was updated successfully or not</returns>
        public bool UpdateAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Update(authorReviewLike);
        }

        /// <summary>
        /// Delete the author review like provided as a parameter
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>A boolean value indicating whether the author review like was deleted successfully or not</returns>
        public bool DeleteAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Remove(authorReviewLike);
        }
    }
}
