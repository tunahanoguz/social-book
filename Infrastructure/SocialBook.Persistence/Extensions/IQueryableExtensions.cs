using Microsoft.EntityFrameworkCore;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;

namespace SocialBook.Persistence.Extensions
{
    public static class IQueryableExtensions
    {
        public async static Task<PaginatedListDto<T>> ToPaginatedList<T>(this IQueryable<T> queryable, PaginationFilter paginationFilter)
        {
            var queryableData = queryable
                .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                .Take(paginationFilter.PageSize);

            var data = await queryableData.ToListAsync();
            var totalRecords = await queryable.CountAsync();
            var totalPages = Convert.ToInt32(Math.Ceiling((double)totalRecords / (double)paginationFilter.PageSize));

            return new PaginatedListDto<T>(data, totalRecords, totalPages, paginationFilter.PageNumber, paginationFilter.PageSize);
        }
    }
}
