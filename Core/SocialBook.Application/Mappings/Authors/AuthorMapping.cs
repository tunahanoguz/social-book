using AutoMapper;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, CreateAuthorQueryRequest>().ReverseMap();
            CreateMap<Author, UpdateAuthorQueryRequest>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
