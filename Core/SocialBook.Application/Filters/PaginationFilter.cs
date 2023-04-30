using Microsoft.AspNetCore.Mvc;

namespace SocialBook.Application.Filters
{
    /// <summary>
    /// Represents a filter to paginate the queried data
    /// </summary>
    public class PaginationFilter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PaginationFilter()
        {
            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        public PaginationFilter(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// The page number
        /// </summary>
        /// <example>1</example>
        [FromQuery]
        public int PageNumber { get; set; }

        /// <summary>
        /// The maximum number of records that can be returned
        /// </summary>
        /// <example>5</example>
        [FromQuery]
        public int PageSize { get; set; }
    }
}
