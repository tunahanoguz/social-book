using AutoMapper;
using SocialBook.Application.DTOs.Common;

namespace SocialBook.Application.Mappings
{
    public class CommonMapping : Profile
    {
        public CommonMapping()
        {
            CreateMap(typeof(PaginatedListDto<>), typeof(PaginatedListDto<>));
        }
    }
}
