using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewsByRatingQueryHandler : IRequestHandler<GetAuthorReviewsByRatingQueryRequest, PaginatedListDto<AuthorReviewDto>>
    {
        private readonly IAuthorReviewService _authorReviewService;
        private readonly IMapper _mapper;

        public GetAuthorReviewsByRatingQueryHandler(IAuthorReviewService authorReviewService, IMapper mapper)
        {
            _authorReviewService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewDto>> Handle(GetAuthorReviewsByRatingQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewService.GetAuthorReviewsByRatingAsync(request.Rating, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewDto>>(data);
        }
    }
}
