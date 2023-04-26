using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsNotAllowedSubscriptionQueryRequest : IRequest<List<GetAuthorsNotAllowedSubscriptionQueryResponse>>
    {
    }
}
