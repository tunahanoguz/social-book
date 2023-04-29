using SocialBook.Application.Filters;
using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.Application.Services.Common
{
    /// <summary>
    /// Represents the service that contains methods for generating URLs and calculating record counts for paging structure
    /// </summary>
    public interface IPaginationService
    {
        /// <summary>
        /// Create first, last, next and previous page uri
        /// </summary>
        /// <param name="filter">The pagination filter</param>
        /// <returns>The pagination-related page uri</returns>
        Uri CreatePageUri(PaginationFilter filter);

        /// <summary>
        /// Create the paginated result to be returned
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data belonging to the current page that contains the specified number of records</param>
        /// <param name="totalRecords">The total records of the generic data</param>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        /// <param name="message">The response message</param>
        /// <returns>The paginated result to be returned</returns>
        IPaginatedDataResult<T> CreatePaginatedDataResult<T>(HttpStatusCode statusCode, IReadOnlyList<T> data, int totalRecords, int pageNumber, int pageSize, string message);
    }
}
