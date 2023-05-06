using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorImage;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

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
        /// Get all images belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorImage/AuthorId/{AuthorId}
        ///     
        ///     /AuthorImage/AuthorId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All images belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all images belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorId/{AuthorId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorImageDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewsByAuthorId([FromRoute] GetAuthorImagesByAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
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
