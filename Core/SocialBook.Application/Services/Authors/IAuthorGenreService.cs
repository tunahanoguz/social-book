using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorGenreService
    {
        /// <summary>
        /// Create a new author genre
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author genre was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorGenreAsync(AuthorGenre authorGenre);

        /// <summary>
        /// Update the author genre provided as a parameter
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>A boolean value indicating whether the author genre was updated successfully or not</returns>
        bool UpdateAuthorGenre(AuthorGenre authorGenre);

        /// <summary>
        /// Delete the author genre provided as a parameter
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>A boolean value indicating whether the author genre was deleted successfully or not</returns>
        bool DeleteAuthorGenre(AuthorGenre authorGenre);
    }
}
