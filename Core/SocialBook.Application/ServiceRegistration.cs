using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SocialBook.Application.Interfaces.Services;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Application.Services.Common;
using System.Reflection;

namespace SocialBook.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(typeof(ServiceRegistration).Assembly);
            services.AddFluentValidationAutoValidation();
            services.AddSwaggerGen(options =>
            {
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IAuthorGenreService, AuthorGenreService>();
            services.AddScoped<IAuthorImageService, AuthorImageService>();
            services.AddScoped<IAuthorReviewService, AuthorReviewService>();
            services.AddScoped<IAuthorReviewImageService, AuthorReviewImageService>();
            services.AddScoped<IAuthorReviewLikeService, AuthorReviewLikeService>();
            services.AddScoped<IAuthorReviewDislikeService, AuthorReviewDislikeService>();
            services.AddScoped<IAuthorRecommendationService, AuthorRecommendationService>();
            services.AddScoped<IAuthorSubscriptionService, AuthorSubscriptionService>();
            services.AddScoped<IPaginationUriService, PaginationUriService>();
        }
    }
}
