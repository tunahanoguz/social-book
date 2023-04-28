namespace SocialBook.Application.Results
{
    /// <summary>
    /// Represents the result in controllers where not-paginated data is returned
    /// </summary>
    /// <typeparam name="T">The type of data</typeparam>
    public interface INotPaginatedDataResult<out T> : IBaseResult
    {
        /// <summary>
        /// The generic data
        /// </summary>
        T Data { get; }

        /// <summary>
        /// The total records of the generic data
        /// </summary>
        int TotalRecords { get; }
    }
}
