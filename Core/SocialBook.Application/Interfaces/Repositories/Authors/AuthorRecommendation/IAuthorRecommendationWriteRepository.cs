using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Repositories.Authors
{
    public interface IAuthorRecommendationWriteRepository : IWriteRepository<AuthorRecommendation>
    {
    }
}
