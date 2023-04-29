using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SocialBook.Application.Services.Common;
using SocialBook.Infrastructure.Services.Common;

namespace SocialBook.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IPaginationService>(opt =>
            {
                var httpContextAccessor = opt.GetRequiredService<IHttpContextAccessor>();
                return new PaginationService(httpContextAccessor);
            });
        }
    }
}
