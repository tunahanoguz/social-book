using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorGenre;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorGenresByAuthorIdQueryHandler : IRequestHandler<GetAuthorGenresByAuthorIdQueryRequest, PaginatedListDto<AuthorGenreDto>>
    {
        private readonly IAuthorGenreService _authorGenreService;
        private readonly IMapper _mapper;

        public GetAuthorGenresByAuthorIdQueryHandler(IAuthorGenreService authorGenreService, IMapper mapper)
        {
            _authorGenreService = authorGenreService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorGenreDto>> Handle(GetAuthorGenresByAuthorIdQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorGenreService.GetAuthorGenresByAuthorId(request.AuthorId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorGenreDto>>(data);
        }
    }
}
