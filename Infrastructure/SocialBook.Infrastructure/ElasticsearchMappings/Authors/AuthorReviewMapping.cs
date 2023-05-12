using Nest;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Infrastructure.ElasticsearchMappings
{
    public static partial class ElasticsearchMapping
    {
        public static CreateIndexDescriptor AuthorReviewMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<AuthorReview>(m => m.Properties(p => p
                .Keyword(k => k.Name(n => n.Id))
                .Number(n => n.Name(n => n.Rating))
                .Text(t => t.Name(n => n.Comment))
                .Text(t => t.Name(n => n.AuthorId))
                .Text(t => t.Name(n => n.UserId))
            ));
        }
    }
}
