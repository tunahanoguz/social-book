using Microsoft.Extensions.Configuration;
using Nest;
using SocialBook.Application.Services.Common;

namespace SocialBook.Infrastructure.Services
{
    public class ElasticsearchService<T> : IElasticsearchService<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private readonly IElasticClient _elasticClient;

        public ElasticsearchService(IConfiguration configuration)
        {
            _configuration = configuration;
            _elasticClient = CreateInstance();
        }

        private ElasticClient CreateInstance()
        {
            string host = _configuration.GetSection("ElasticsearchServer:Host").Value;
            string port = _configuration.GetSection("ElasticsearchServer:Port").Value;
            string username = _configuration.GetSection("ElasticsearchServer:Username").Value;
            string password = _configuration.GetSection("ElasticsearchServer:Password").Value;

            var settings = new ConnectionSettings(new Uri($"{host}:{port}"));

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                settings.BasicAuthentication(username, password);
            }

            return new ElasticClient(settings);
        }

        public async Task<bool> CheckIndex(string indexName)
        {
            var response = await _elasticClient.Indices.ExistsAsync(indexName);

            return response.Exists;
        }

        public async Task InsertDocument(string indexName, T entity)
        {
            var response = await _elasticClient.CreateAsync(entity, q => q.Index(indexName));

            if (response.ApiCall.HttpStatusCode == 409)
            {
                await _elasticClient.UpdateAsync<T>(response.Id, a => a.Index(indexName).Doc(entity));
            }
        }

        public async Task InsertDocuments(string indexName, IEnumerable<T> entities)
        {
            await _elasticClient.IndexManyAsync(entities, indexName);
        }

        public async Task<T> GetDocument(string indexName, string id)
        {
            var response = await _elasticClient.GetAsync<T>(id, q => q.Index(indexName));

            return response.Source;
        }

        public async Task<IEnumerable<T>> GetDocuments(string indexName)
        {
            var response = await _elasticClient.SearchAsync<T>(q => q.Index(indexName).Scroll("5m"));

            return response.Documents;
        }
    }
}
