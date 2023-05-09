using Nest;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Infrastructure.ElasticsearchMappings
{
    public static partial class ElasticsearchMapping
    {
        public static CreateIndexDescriptor BookReviewMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<BookReview>(m => m.Properties(p => p
                .Keyword(k => k.Name(n => n.Id))
                .Number(n => n.Name(n => n.Rating))
                .Text(t => t.Name(n => n.Comment))
                .Text(t => t.Name(n => n.BookId))
                .Text(t => t.Name(n => n.UserId))
            ));
        }
    }
}
