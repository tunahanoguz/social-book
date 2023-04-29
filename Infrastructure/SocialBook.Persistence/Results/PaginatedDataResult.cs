using SocialBook.Application.Filters;
using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.Persistence.Results
{
    /// <summary>
    /// Represents the result in controllers where paginated data is returned
    /// </summary>
    /// <typeparam name="T">The type of data</typeparam>
    public class PaginatedDataResult<T> : BaseResult, IPaginatedDataResult<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data</param>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        public PaginatedDataResult(HttpStatusCode statusCode, IReadOnlyList<T> data, PaginationFilter paginationFilter) : base(statusCode)
        {
            this.Data = data;
            this.PageNumber = paginationFilter.PageNumber;
            this.PageSize = paginationFilter.PageSize;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data</param>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        /// <param name="message">The response message</param>
        public PaginatedDataResult(HttpStatusCode statusCode, IReadOnlyList<T> data, PaginationFilter paginationFilter, string message) : base(statusCode, message)
        {
            this.Data = data;
            this.PageNumber = paginationFilter.PageNumber;
            this.PageSize = paginationFilter.PageSize;
        }

        /// <inheritdoc />
        public IReadOnlyList<T> Data { get; set; }

        /// <inheritdoc />
        public int PageNumber { get; set; }

        /// <inheritdoc />
        public int PageSize { get; set; }

        /// <inheritdoc />
        public Uri? FirstPage { get; set; }

        /// <inheritdoc />
        public Uri? LastPage { get; set; }

        /// <inheritdoc />
        public int TotalPages { get; set; } = 0;

        /// <inheritdoc />
        public int TotalRecords { get; set; } = 0;

        /// <inheritdoc />
        public Uri? NextPage { get; set; }

        /// <inheritdoc />
        public Uri? PreviousPage { get; set; }
    }
}
