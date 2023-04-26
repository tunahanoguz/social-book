using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsAllowedRecommendationQueryRequest : IRequest<List<GetAuthorsAllowedRecommendationQueryResponse>>
    {
    }
}
