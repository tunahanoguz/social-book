using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorImage;
using SocialBook.Application.Features.Commands;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Upload image for an author
        /// </summary>
        /// <param name="request">The created author image</param>
        /// <returns>Returns the created author image</returns>
        [HttpPost("AuthorId/{AuthorId}")]
        [ProducesResponseType(typeof(AuthorImageDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthorImage([FromRoute] CreateAuthorImageCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author image
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorImage/{Id}
        ///     
        ///     /AuthorImage/6a899c34-e51e-443d-a315-959136f3e49b
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthorImage([FromRoute] DeleteAuthorImageCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
