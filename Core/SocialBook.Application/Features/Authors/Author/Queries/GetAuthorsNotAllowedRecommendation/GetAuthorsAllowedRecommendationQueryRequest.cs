using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsNotAllowedRecommendationQueryRequest : IRequest<List<GetAuthorsNotAllowedRecommendationQueryResponse>>
    {
    }
}
