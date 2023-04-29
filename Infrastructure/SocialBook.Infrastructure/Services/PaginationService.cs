using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using SocialBook.Application.Filters;
using SocialBook.Application.Results;
using SocialBook.Application.Services.Common;
using SocialBook.Infrastructure.Extensions;
using System.Net;

namespace SocialBook.Infrastructure.Services.Common
{
    /// <inheritdoc />
    public class PaginationService : IPaginationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaginationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <inheritdoc />
        public Uri CreatePageUri(PaginationFilter filter)
        {
            var baseUri = _httpContextAccessor.GetRequestUri();
            var route = _httpContextAccessor.GetRoute();
            var endpoint = new Uri(string.Concat(baseUri, route));
            var queryUri = QueryHelpers.AddQueryString($"{endpoint}", "pageNumber", $"{filter.PageNumber}");
            queryUri = QueryHelpers.AddQueryString(queryUri, "pageSize", $"{filter.PageSize}");

            return new Uri(queryUri);
        }

        /// <inheritdoc />
        public IPaginatedDataResult<T> CreatePaginatedDataResult<T>(HttpStatusCode statusCode, IReadOnlyList<T> data, int pageNumber, int pageSize, string message)
        {
            throw new NotImplementedException();
        }
    }
}
