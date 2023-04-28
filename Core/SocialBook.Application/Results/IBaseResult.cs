namespace SocialBook.Application.Results
{
    /// <summary>
    /// Represents the base result for paginated and not-paginated results
    /// </summary>
    public interface IBaseResult
    {
        /// <summary>
        /// The HTTP status code
        /// </summary>
        int StatusCode { get; }

        /// <summary>
        /// The response message
        /// </summary>
        string Message { get; }
    }
}
