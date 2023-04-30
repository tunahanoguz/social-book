using AutoMapper;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, CreateAuthorQueryRequest>().ReverseMap();
            CreateMap<Author, UpdateAuthorQueryRequest>().ReverseMap();

            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap(typeof(PaginatedListDto<>), typeof(PaginatedListDto<>));
        }
    }
}
