using AutoMapper;
using SocialBook.Application.Features;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, GetAuthorByIdQueryResponse>().ReverseMap();
        }
    }
}
