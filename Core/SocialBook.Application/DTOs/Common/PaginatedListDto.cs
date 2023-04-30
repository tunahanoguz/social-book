namespace SocialBook.Application.DTOs.Common
{
    /// <summary>
    /// Represents the paginated data list returned from a read repository method
    /// </summary>
    /// <typeparam name="T">The type of data</typeparam>
    public class PaginatedListDto<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PaginatedListDto()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">The queryable data returned from a read repository method</param>
        /// <param name="totalRecords">Total number of records for the queried data</param>
        /// <param name="totalPages">Total number of pages for the queried data</param>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageSize">The maximum number of records that can be returned</param>
        /// <param name="firstPage">The first page</param>
        /// <param name="lastPage">The last page</param>
        /// <param name="previousPage">The previous page</param>
        /// <param name="nextPage">The next page</param>
        public PaginatedListDto(IEnumerable<T> data, int totalRecords, int totalPages, int pageNumber, int pageSize)
        {
            this.Data = data;
            this.TotalRecords = totalRecords;
            this.TotalPages = totalPages;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// The queryable data returned from a read repository method
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Total number of records for the queried data
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// Total number of pages for the queried data
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// The page number
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// The maximum number of records that can be returned
        /// </summary>
        public int PageSize { get; set; }
    }
}
