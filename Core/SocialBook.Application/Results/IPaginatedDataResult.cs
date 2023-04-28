namespace SocialBook.Application.Results
{
    /// <summary>
    /// Represents the result in controllers where paginated data is returned
    /// </summary>
    /// <typeparam name="T">The type of data</typeparam>
    public interface IPaginatedDataResult<out T> : IBaseResult
    {
        /// <summary>
        /// The generic data belonging to the current page that contains the specified number of records
        /// </summary>
        IReadOnlyList<T> Data { get; }

        /// <summary>
        /// The page number
        /// </summary>
        int PageNumber { get; set; }

        /// <summary>
        /// The number of records to be returned
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// The first page url
        /// </summary>
        Uri FirstPage { get; }

        /// <summary>
        /// The last page url
        /// </summary>
        Uri LastPage { get; }

        /// <summary>
        /// Total number of pages for the queried data
        /// </summary>
        int TotalPages { get; }

        /// <summary>
        /// Total number of records for the queried data
        /// </summary>
        int TotalRecords { get; }

        /// <summary>
        /// The next page url
        /// </summary>
        Uri NextPage { get; }

        /// <summary>
        /// The previous page url
        /// </summary>
        Uri PreviousPage { get; }
    }
}
