using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewLikesByAuthorReviewQueryHandler : IRequestHandler<GetAuthorReviewLikesByAuthorReviewQueryRequest, PaginatedListDto<AuthorReviewLikeDto>>
    {
        private readonly IAuthorReviewLikeService _authorReviewLikeService;
        private readonly IMapper _mapper;

        public GetAuthorReviewLikesByAuthorReviewQueryHandler(IAuthorReviewLikeService authorReviewService, IMapper mapper)
        {
            _authorReviewLikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewLikeDto>> Handle(GetAuthorReviewLikesByAuthorReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewLikeService.GetAuthorReviewLikesByAuthorReviewAsync(request.AuthorReviewId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewLikeDto>>(data);
        }
    }
}
