using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorGenre;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorGenreMapping : Profile
    {
        public AuthorGenreMapping()
        {
            CreateMap<AuthorGenre, AuthorGenreDto>().ReverseMap();
            CreateMap<AuthorGenre, CreateAuthorGenreCommandRequest>().ReverseMap();
        }
    }
}
