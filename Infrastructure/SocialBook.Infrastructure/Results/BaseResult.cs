using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.Infrastructure.Results
{
    /// <inheritdoc />
    public class BaseResult : IBaseResult
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        public BaseResult(HttpStatusCode statusCode)
        {
            StatusCode = (int)statusCode;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusCode">The HTTP status code</param>
        /// <param name="message">The response message</param>
        public BaseResult(HttpStatusCode statusCode, string message) : this(statusCode)
        {
            Message = message;
        }

        /// <inheritdoc />
        public int StatusCode { get; }

        /// <inheritdoc />
        public string? Message { get; }
    }
}
