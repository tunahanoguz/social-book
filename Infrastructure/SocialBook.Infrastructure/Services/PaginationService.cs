using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using SocialBook.Application.Filters;
using SocialBook.Application.Results;
using SocialBook.Application.Services.Common;
using SocialBook.Infrastructure.Extensions;
using SocialBook.Infrastructure.Results;
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
        public IPaginatedDataResult<T> CreatePaginatedDataResult<T>(HttpStatusCode statusCode, IReadOnlyList<T> data, int totalRecords, int pageNumber, int pageSize, string message)
        {
            var result = new PaginatedDataResult<T>(statusCode, data, pageNumber, pageSize);
            result.TotalRecords = totalRecords;
            result.TotalPages = Convert.ToInt32(Math.Ceiling((double)totalRecords / (double)pageSize));
            result.FirstPage = this.CreatePageUri(new PaginationFilter(1, pageSize));
            result.LastPage = this.CreatePageUri(new PaginationFilter(result.TotalPages, pageSize));
            result.PreviousPage = this.CreatePageUri(new PaginationFilter(pageNumber - 1, pageSize));
            result.NextPage = this.CreatePageUri(new PaginationFilter(pageNumber + 1, pageSize));

            return result;
        }
    }
}
