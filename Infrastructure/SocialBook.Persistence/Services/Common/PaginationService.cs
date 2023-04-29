using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using SocialBook.Application.Filters;
using SocialBook.Application.Results;
using SocialBook.Application.Services.Common;
using SocialBook.Persistence.Extensions;
using SocialBook.Persistence.Results;
using System.Net;

namespace SocialBook.Persistence.Services.Common
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
        public Uri CreatePageUri(PaginationFilter paginationFilter)
        {
            var baseUri = _httpContextAccessor.GetRequestUri();
            var route = _httpContextAccessor.GetRoute();
            var endpoint = new Uri(string.Concat(baseUri, route));
            var queryUri = QueryHelpers.AddQueryString($"{endpoint}", "pageNumber", $"{paginationFilter.PageNumber}");
            queryUri = QueryHelpers.AddQueryString(queryUri, "pageSize", $"{paginationFilter.PageSize}");

            return new Uri(queryUri);
        }

        /// <inheritdoc />
        public IPaginatedDataResult<T> CreatePaginatedDataResult<T>(HttpStatusCode statusCode, IReadOnlyList<T> data, int totalRecords, PaginationFilter paginationFilter, string message)
        {
            var result = new PaginatedDataResult<T>(statusCode, data, new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize));

            var totalPages = Convert.ToInt32(Math.Ceiling((double)totalRecords / (double)paginationFilter.PageSize));

            result.TotalRecords = totalRecords;
            result.TotalPages = totalPages;
            result.FirstPage = this.CreatePageUri(new PaginationFilter(1, paginationFilter.PageSize));
            result.LastPage = this.CreatePageUri(new PaginationFilter(result.TotalPages, paginationFilter.PageSize));

            result.PreviousPage = paginationFilter.PageNumber - 1 >= 1 && paginationFilter.PageNumber <= totalPages
                ? this.CreatePageUri(new PaginationFilter(paginationFilter.PageNumber - 1, paginationFilter.PageSize))
                : null;

            result.NextPage = paginationFilter.PageNumber >= 1 && paginationFilter.PageNumber < totalPages
                ? this.CreatePageUri(new PaginationFilter(paginationFilter.PageNumber + 1, paginationFilter.PageSize))
                : null;

            return result;
        }
    }
}
