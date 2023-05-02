using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorGenreService
    {
        /// <summary>
        /// Gets all author genres belonging to the author whose identifier is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author genres belonging to the author whose identifier is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorGenre>> GetAuthorGenresByAuthorId(string authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author genre
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author genre was created successfully or not
        /// </returns>
        Task<AuthorGenre> CreateAuthorGenreAsync(AuthorGenre authorGenre);

        /// <summary>
        /// Delete the author genre provided as a parameter
        /// </summary>
        /// <param name="authorGenreId">The author genre identifier</param>
        /// <returns>A boolean value indicating whether the author genre was deleted successfully or not</returns>
        Task<bool> DeleteAuthorGenreAsync(string authorGenreId);
    }
}
