using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewImageCommandRequest : IRequest<AuthorReviewImageDto>
    {
        /// <summary>
        /// The author review identifier
        /// </summary>
        /// <example>2823add5-60f3-4272-9ec1-087d69cca72c</example>
        [FromRoute]
        public Guid AuthorReviewId { get; set; }

        /// <summary>
        /// The author image
        /// </summary>
        [FromForm]
        public IFormFile Image { get; set; }
    }
}
