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
            CreateMap<Author, CreateAuthorCommandRequest>().ReverseMap();
            CreateMap<Author, UpdateAuthorCommandRequest>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
