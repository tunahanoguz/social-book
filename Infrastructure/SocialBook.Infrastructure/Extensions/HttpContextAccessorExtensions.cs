using Microsoft.AspNetCore.Http;

namespace SocialBook.Infrastructure.Extensions
{
    /// <summary>
    /// Represents all extensions for HttpContextAccessor
    /// </summary>
    public static class HttpContextAccessorExtensions
    {
        /// <summary>
        /// Get the request uri
        /// </summary>
        /// <param name="httpContextAccessor">The http context accessor</param>
        /// <returns>The request uri</returns>
        /// <exception cref="ArgumentNullException">If the HttpContextAccessor is null</exception>
        public static string GetRequestUri(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
            {
                throw new ArgumentNullException(nameof(httpContextAccessor));
            }

            var request = httpContextAccessor.HttpContext.Request;

            return string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
        }

        /// <summary>
        /// Get the request path value
        /// </summary>
        /// <param name="httpContextAccessor">The http context accessor</param>
        /// <returns>The request path value</returns>
        /// <exception cref="ArgumentNullException">If the HttpContextAccessor is null</exception>
        public static string GetRoute(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
            {
                throw new ArgumentNullException(nameof(httpContextAccessor));
            }

            return httpContextAccessor.HttpContext.Request.Path.Value;
        }
    }
}
