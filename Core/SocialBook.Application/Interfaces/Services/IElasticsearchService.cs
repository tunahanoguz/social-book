using Nest;

namespace SocialBook.Application.Interfaces.Services
{
    /// <summary>
    /// Represents the service that contains methods for Elasticsearch usage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IElasticsearchService<T> where T : class
    {
        /// <summary>
        /// Check whether the index provided as a parameter exists or not
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <returns>The boolean value indicating whether the index provided as a parameter exists or not</returns>
        Task<bool> CheckIndexAsync(string indexName);

        /// <summary>
        /// Insert a single document
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="indexName">The index name</param>
        /// <param name="entity">The entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDocumentAsync(string indexName, T entity);

        /// <summary>
        /// Insert multiple documents
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="indexName">The index name</param>
        /// <param name="entities">The entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertDocumentsAsync(string indexName, IEnumerable<T> entities);

        /// <summary>
        /// Get a single entity
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the document queried from Elasticsearch
        /// </returns>
        Task<T> GetDocumentByIdAsync(string indexName, string id);

        /// <summary>
        /// Get multiple documents
        /// </summary>
        /// <param name="indexName">The index name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the documents queried from Elasticsearch
        /// </returns>
        Task<IEnumerable<T>> GetDocumentsAsync(string indexName);

        /// <summary>
        /// Search document by search descriptor
        /// </summary>
        /// <param name="searchDescriptor"></param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the documents queried from Elasticsearch
        /// </returns>
        Task<IEnumerable<T>> SearchDocumentsAsync(Func<SearchDescriptor<T>, ISearchRequest> searchDescriptor);

        /// <summary>
        /// Remove a single entity
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task RemoveDocumentByIdAsync(string id);
    }
}
