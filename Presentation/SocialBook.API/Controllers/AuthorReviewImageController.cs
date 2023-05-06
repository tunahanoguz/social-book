using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorReviewImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorReviewImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all images associated with the author review whose ID is provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReviewImage/AuthorReviewId/{AuthorReviewId}
        ///     
        ///     /AuthorReviewImage/AuthorReviewId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All images associated with the author review whose ID is provided as a parameter</returns>
        /// <response code="200">Returns all images associated with the author review whose ID is provided as a parameter</response>
        [HttpGet("AuthorReviewId/{AuthorReviewId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewImageDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewsByAuthorReviewId([FromRoute] GetAuthorReviewImagesByAuthorReviewQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Upload image for an author review
        /// </summary>
        /// <param name="request">The created author review image</param>
        /// <returns>Returns the created author review image</returns>
        [HttpPost("AuthorReviewId/{AuthorReviewId}")]
        [ProducesResponseType(typeof(AuthorReviewImageDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthorReviewImage([FromRoute] CreateAuthorReviewImageCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author review image
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorReviewImage/{Id}
        ///     
        ///     /AuthorReviewImage/6a899c34-e51e-443d-a315-959136f3e49b
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthorReviewImage([FromRoute] DeleteAuthorReviewImageCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
