using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsNotAllowedReviewQueryRequest : IRequest<List<GetAuthorsNotAllowedReviewQueryResponse>>
    {
    }
}
