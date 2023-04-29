using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.Persistence.Results
{
    /// <summary>
    /// Represents the result in controllers where not-paginated data is returned
    /// </summary>
    /// <typeparam name="T">The type of data</typeparam>
    public class NotPaginatedDataResult<T> : BaseResult, INotPaginatedDataResult<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data</param>
        /// <param name="totalRecords">The total records of the generic data</param>
        public NotPaginatedDataResult(HttpStatusCode statusCode, T data, int totalRecords) : base(statusCode)
        {
            this.Data = data;
            this.TotalRecords = totalRecords;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="data">The generic data</param>
        /// <param name="totalRecords">The total records of the generic data</param>
        /// <param name="message">The response message</param>
        public NotPaginatedDataResult(HttpStatusCode statusCode, T data, int totalRecords, string message) : base(statusCode, message)
        {
            this.Data = data;
            this.TotalRecords = totalRecords;
        }

        /// <inheritdoc />
        public T Data { get; }

        /// <inheritdoc />
        public int TotalRecords { get; }
    }
}
