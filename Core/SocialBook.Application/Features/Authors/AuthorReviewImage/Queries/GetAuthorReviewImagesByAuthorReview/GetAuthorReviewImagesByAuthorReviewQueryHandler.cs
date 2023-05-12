using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewImagesByAuthorReviewQueryHandler : IRequestHandler<GetAuthorReviewImagesByAuthorReviewQueryRequest, PaginatedListDto<AuthorReviewImageDto>>
    {
        private readonly IAuthorReviewImageService _authorReviewImageService;
        private readonly IMapper _mapper;

        public GetAuthorReviewImagesByAuthorReviewQueryHandler(IAuthorReviewImageService authorReviewImageService, IMapper mapper)
        {
            _authorReviewImageService = authorReviewImageService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewImageDto>> Handle(GetAuthorReviewImagesByAuthorReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewImageService.GetAuthorReviewImagesByAuthorReviewAsync(request.AuthorReviewId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewImageDto>>(data);
        }
    }
}
