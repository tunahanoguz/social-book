using Nest;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Infrastructure.ElasticsearchMappings
{
    public static partial class ElasticsearchMapping
    {
        public static CreateIndexDescriptor BookMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<Book>(m => m.Properties(p => p
                .Keyword(k => k.Name(n => n.Id))
                .Text(t => t.Name(n => n.Isbn))
                .Text(t => t.Name(n => n.Description))
                .Number(n => n.Name(n => n.PublishedYear))
                .Number(n => n.Name(n => n.PageCount))
                .Text(t => t.Name(n => n.Language))
                .Text(t => t.Name(n => n.MetaTitle))
                .Text(t => t.Name(n => n.MetaDescription))
                .Text(t => t.Name(n => n.MetaKeywords))
                .Text(t => t.Name(n => n.Slug))
                .Boolean(t => t.Name(n => n.IsAllowedReview))
                .Boolean(t => t.Name(n => n.IsAllowedRecommendation))
                .Boolean(t => t.Name(n => n.IsAllowedSubscription))
                .Text(t => t.Name(n => n.CreatorUserId))
            ));
        }
    }
}
