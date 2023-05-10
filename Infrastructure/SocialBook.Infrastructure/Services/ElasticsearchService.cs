using Nest;
using SocialBook.Application.Services.Common;

namespace SocialBook.Infrastructure.Services
{
    public class ElasticsearchService<T> : IElasticsearchService<T> where T : class
    {
        private readonly IElasticClient _elasticClient;

        public ElasticsearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<bool> CheckIndexAsync(string indexName)
        {
            var response = await _elasticClient.Indices.ExistsAsync(indexName);

            return response.Exists;
        }

        public async Task InsertDocumentAsync(string indexName, T entity)
        {
            var response = await _elasticClient.CreateAsync(entity, q => q.Index(indexName));

            if (response.ApiCall.HttpStatusCode == 409)
            {
                await _elasticClient.UpdateAsync<T>(response.Id, a => a.Index(indexName).Doc(entity));
            }
        }

        public async Task InsertDocumentsAsync(string indexName, IEnumerable<T> entities)
        {
            await _elasticClient.IndexManyAsync(entities, indexName);
        }

        public async Task<T> GetDocumentByIdAsync(string indexName, string id)
        {
            var response = await _elasticClient.GetAsync<T>(id, q => q.Index(indexName));

            return response.Source;
        }

        public async Task<IEnumerable<T>> GetDocumentsAsync(string indexName)
        {
            var response = await _elasticClient.SearchAsync<T>(q => q.Index(indexName).Scroll("5m"));

            return response.Documents;
        }

        public async Task<IEnumerable<T>> SearchDocumentsAsync(Func<SearchDescriptor<T>, ISearchRequest> searchDescriptor)
        {
            var response = await _elasticClient.SearchAsync<T>(searchDescriptor);

            return response.Documents;
        }

        public async Task RemoveDocumentByIdAsync(string id)
        {
            await _elasticClient.DeleteAsync<T>(id);
        }
    }
}
