using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using SocialBook.Application.Extensions;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Common;

namespace SocialBook.Application.Services.Common
{
    /// <inheritdoc />
    public class PaginationUriService : IPaginationUriService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaginationUriService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <inheritdoc />
        public Uri CreatePageUri(PaginationFilter paginationFilter)
        {
            var baseUri = _httpContextAccessor.GetRequestUri();
            var route = _httpContextAccessor.GetRoute();
            var endpoint = new Uri(string.Concat(baseUri, route));
            var queryUri = QueryHelpers.AddQueryString($"{endpoint}", "pageNumber", $"{paginationFilter.PageNumber}");
            queryUri = QueryHelpers.AddQueryString(queryUri, "pageSize", $"{paginationFilter.PageSize}");

            return new Uri(queryUri);
        }
    }
}
