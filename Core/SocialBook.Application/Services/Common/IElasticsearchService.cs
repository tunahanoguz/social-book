namespace SocialBook.Application.Services.Common
{
    /// <summary>
    /// Represents the service that contains methods for Elasticsearch usage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IElasticsearchService<T>
    {
        /// <summary>
        /// Check whether the index provided as a parameter exists or not
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <returns>The boolean value indicating whether the index provided as a parameter exists or not</returns>
        Task<bool> CheckIndex(string indexName);

        /// <summary>
        /// Insert a single document
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="indexName">The index name</param>
        /// <param name="entity">The entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDocument<T>(string indexName, T entity);

        /// <summary>
        /// Insert multiple documents
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="indexName">The index name</param>
        /// <param name="entities">The entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDocuments<T>(string indexName, IEnumerable<T> entities);

        /// <summary>
        /// Get a single entity
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the document queried from Elasticsearch
        /// </returns>
        Task<T> GetDocument(string indexName, string id);

        /// <summary>
        /// Get multiple documents
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the documents queried from Elasticsearch
        /// </returns>
        Task<IEnumerable<T>> GetDocuments(string indexName);
    }
}
