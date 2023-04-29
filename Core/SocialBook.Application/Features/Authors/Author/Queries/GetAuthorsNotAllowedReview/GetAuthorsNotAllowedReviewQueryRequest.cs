using MediatR;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedReviewQueryRequest : PaginationFilter, IRequest<List<GetAuthorsNotAllowedReviewQueryResponse>>
    {
    }
}
