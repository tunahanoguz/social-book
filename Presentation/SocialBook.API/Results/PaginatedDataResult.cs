using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.API.Results
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
        public PaginatedDataResult(HttpStatusCode statusCode, IReadOnlyList<T> data, int pageNumber, int pageSize) : base(statusCode)
        {
            this.Data = data;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data</param>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        /// <param name="message">The response message</param>
        public PaginatedDataResult(HttpStatusCode statusCode, IReadOnlyList<T> data, int pageNumber, int pageSize, string message) : base(statusCode, message)
        {
            this.Data = data;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <inheritdoc />
        public IReadOnlyList<T> Data { get; }

        /// <inheritdoc />
        public int PageNumber { get; set; }

        /// <inheritdoc />
        public int PageSize { get; set; }

        /// <inheritdoc />
        public Uri? FirstPage { get; }

        /// <inheritdoc />
        public Uri? LastPage { get; }

        /// <inheritdoc />
        public int TotalPages { get; } = 0;

        /// <inheritdoc />
        public int TotalRecords { get; } = 0;

        /// <inheritdoc />
        public Uri? NextPage { get; }

        /// <inheritdoc />
        public Uri? PreviousPage { get; }
    }
}
