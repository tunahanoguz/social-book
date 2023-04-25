using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorRecommendationService : IAuthorRecommendationService
    {
        private readonly IAuthorRecommendationReadRepository _authorRecommendationReadRepository;
        private readonly IAuthorRecommendationWriteRepository _authorRecommendationWriteRepository;

        public AuthorRecommendationService(IAuthorRecommendationReadRepository authorRecommendationReadRepository,
            IAuthorRecommendationWriteRepository authorRecommendationWriteRepository)
        {
            _authorRecommendationReadRepository = authorRecommendationReadRepository;
            _authorRecommendationWriteRepository = authorRecommendationWriteRepository;
        }

        /// <summary>
        /// Get author recommendations belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorRecommendationReadRepository.GetAuthorRecommendationsByAuthorAsync(authorId);
        }

        /// <summary>
        /// Get author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recommenderUserId">The recommender user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </returns>
        public Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId)
        {
            if (recommenderUserId == null) { throw new ArgumentNullException(nameof(recommenderUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecommenderUserAsync(recommenderUserId);
        }

        /// <summary>
        /// Get author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recipientUserId">The recipient user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </returns>
        public Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId)
        {
            if (recipientUserId == null) { throw new ArgumentNullException(nameof(recipientUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecipientUserAsync(recipientUserId);
        }

        /// <summary>
        /// Create a new author recommendation
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author recommendation was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return await _authorRecommendationWriteRepository.AddAsync(authorRecommendation);
        }

        /// <summary>
        /// Update the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was updated successfully or not</returns>
        public bool UpdateRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Update(authorRecommendation);
        }

        /// <summary>
        /// Delete the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was deleted successfully or not</returns>
        public bool DeleteRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Remove(authorRecommendation);
        }
    }
}
