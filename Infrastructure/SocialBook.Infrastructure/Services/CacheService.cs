using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SocialBook.Application.Interfaces.Services;

namespace SocialBook.Infrastructure.Services
{
    /// <inheritdoc />
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IMapper _mapper;

        public CacheService(IDistributedCache distributedCache, IMapper mapper)
        {
            _distributedCache = distributedCache;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<T?> GetAsync<T>(string key)
        {
            if (string.IsNullOrEmpty(key)) { throw new ArgumentNullException(nameof(key)); }

            var value = await _distributedCache.GetStringAsync(key);

            return string.IsNullOrEmpty(value) ? default : JsonConvert.DeserializeObject<T>(value);
        }

        /// <inheritdoc />
        public async Task SetAsync<T>(string key, T value, DateTimeOffset? absoluteExpiration = null, TimeSpan? slidingExpiration = null)
        {
            if (string.IsNullOrEmpty(key)) { throw new ArgumentNullException(nameof(key)); }

            if (value == null) { throw new ArgumentNullException(nameof(value)); }

            if (absoluteExpiration == null)
            {
                absoluteExpiration = DateTime.Now.AddMinutes(60);
            }

            if (slidingExpiration == null)
            {
                slidingExpiration = TimeSpan.FromMinutes(10);
            }

            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = absoluteExpiration,
                SlidingExpiration = slidingExpiration,
            };

            await _distributedCache.SetStringAsync(key, JsonConvert.SerializeObject(value), options);
        }

        /// <inheritdoc />
        public async Task RemoveAsync(string key)
        {
            if (string.IsNullOrEmpty(key)) { throw new ArgumentNullException(nameof(key)); }

            await _distributedCache.RemoveAsync(key);
        }
    }
}
