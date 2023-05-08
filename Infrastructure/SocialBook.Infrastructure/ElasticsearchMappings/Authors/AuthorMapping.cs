using Nest;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Infrastructure.ElasticsearchMappings.Authors
{
    public static partial class ElasticsearchMapping
    {
        public static CreateIndexDescriptor AuthorMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<Author>(m => m.Properties(p => p
                .Keyword(k => k.Name(n => n.Id))
                .Text(t => t.Name(n => n.FirstName))
                .Text(t => t.Name(n => n.LastName))
                .Text(t => t.Name(n => n.Description))
                .Text(t => t.Name(n => n.CountryOfBirth))
                .Date(d => d.Name(n => n.DateOfBirth))
                .Text(t => t.Name(n => n.MetaTitle))
                .Text(t => t.Name(n => n.MetaDescription))
                .Text(t => t.Name(n => n.MetaKeywords))
                .Text(t => t.Name(n => n.Slug))
                .Boolean(b => b.Name(n => n.IsAllowedReview))
                .Boolean(b => b.Name(n => n.IsAllowedRecommendation))
                .Boolean(b => b.Name(n => n.IsAllowedSubscription))
                .Text(t => t.Name(n => n.CreatorUserId))
            ));
        }
    }
}
