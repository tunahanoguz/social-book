namespace SocialBook.Application.Services.Common
{
    /// <summary>
    /// The interface for cache service
    /// </summary>
    public interface ICacheService
    {
        /// <summary>
        /// Get the value corresponding to the given key
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="key">The key of key-value pair</param>
        /// <returns>The value corresponding to the given key</returns>
        Task<T?> GetAsync<T>(string key);

        /// <summary>
        /// Set the value for the given key
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="key">The key of key-value pair</param>
        /// <param name="value">The value of key-value pair</param>
        /// <param name="absoluteExpiration">The maximum time the data can be stored in cache</param>
        /// <param name="slidingExpiration">The minimum time the data can be stored in cache unless re-queried</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task SetAsync<T>(string key, T value, DateTimeOffset? absoluteExpiration, TimeSpan? slidingExpiration);

        /// <summary>
        /// Remove the value for the given key
        /// </summary>
        /// <param name="key">The key of key-value pair</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task RemoveAsync(string key);
    }
}
