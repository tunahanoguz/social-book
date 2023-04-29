using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedReviewQueryRequest : PaginationFilter, IRequest<List<GetAuthorsAllowedReviewQueryResponse>>
    {
    }
}
