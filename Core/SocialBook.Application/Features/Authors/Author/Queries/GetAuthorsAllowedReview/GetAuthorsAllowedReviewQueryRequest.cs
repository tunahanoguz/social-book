using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsAllowedReviewQueryRequest : IRequest<List<GetAuthorsAllowedReviewQueryResponse>>
    {
    }
}
