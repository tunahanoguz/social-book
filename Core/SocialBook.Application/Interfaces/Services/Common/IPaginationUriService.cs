using SocialBook.Application.Filters;

namespace SocialBook.Application.Interfaces.Services.Common
{
    /// <summary>
    /// Represents the service that contains methods for generating URLs and calculating record counts for paging structure
    /// </summary>
    public interface IPaginationUriService
    {
        /// <summary>
        /// Create first, last, next and previous page uri
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>The pagination-related page uri</returns>
        Uri CreatePageUri(PaginationFilter paginationFilter);
    }
}
