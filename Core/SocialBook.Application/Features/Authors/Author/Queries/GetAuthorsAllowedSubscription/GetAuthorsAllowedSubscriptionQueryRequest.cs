using MediatR;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsAllowedSubscriptionQueryRequest : IRequest<List<GetAuthorsAllowedSubscriptionQueryResponse>>
    {
    }
}
