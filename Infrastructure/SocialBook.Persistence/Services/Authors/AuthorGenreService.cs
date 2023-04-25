using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorGenreService : IAuthorGenreService
    {
        private readonly IAuthorGenreReadRepository _authorGenreReadRepository;
        private readonly IAuthorGenreWriteRepository _authorGenreWriteRepository;

        public AuthorGenreService(IAuthorGenreReadRepository authorGenreReadRepository, IAuthorGenreWriteRepository authorGenreWriteRepository)
        {
            _authorGenreReadRepository = authorGenreReadRepository;
            _authorGenreWriteRepository = authorGenreWriteRepository;
        }

        /// <summary>
        /// Create a new author genre
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author genre was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorGenreAsync(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return await _authorGenreWriteRepository.AddAsync(authorGenre);
        }

        /// <summary>
        /// Update the author genre provided as a parameter
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>A boolean value indicating whether the author genre was updated successfully or not</returns>
        public bool UpdateAuthorGenre(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return _authorGenreWriteRepository.Update(authorGenre);
        }

        /// <summary>
        /// Delete the author genre provided as a parameter
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>A boolean value indicating whether the author genre was deleted successfully or not</returns>
        public bool DeleteAuthorGenre(AuthorGenre authorGenre)
        {
            if (authorGenre == null) { throw new ArgumentNullException(nameof(authorGenre)); }

            return _authorGenreWriteRepository.Remove(authorGenre);
        }
    }
}
