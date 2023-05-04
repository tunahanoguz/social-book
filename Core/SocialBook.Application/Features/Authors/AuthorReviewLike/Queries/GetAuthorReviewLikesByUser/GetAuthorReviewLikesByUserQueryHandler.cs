using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors.AuthorReviewLike.Queries.GetAuthorReviewLikesByUser
{
    public class GetAuthorReviewLikesByUserQueryHandler : IRequestHandler<GetAuthorReviewLikesByUserQueryRequest, PaginatedListDto<AuthorReviewLikeDto>>
    {
        private readonly IAuthorReviewLikeService _authorReviewLikeService;
        private readonly IMapper _mapper;

        public GetAuthorReviewLikesByUserQueryHandler(IAuthorReviewLikeService authorReviewService, IMapper mapper)
        {
            _authorReviewLikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewLikeDto>> Handle(GetAuthorReviewLikesByUserQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewLikeService.GetAuthorReviewLikesByUserAsync(request.UserId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewLikeDto>>(data);
        }
    }
}
