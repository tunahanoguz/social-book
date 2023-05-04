using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorReviewDislikeController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorReviewDislikeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all author review dislikes belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReviewDislike/AuthorReviewId/{AuthorId}
        ///     
        ///     /AuthorReviewDislike/AuthorReviewId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author review dislikes belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author review dislikes belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorReviewId/{AuthorReviewId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewDislikeDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewDislikesByAuthorReviewId([FromRoute] GetAuthorReviewDislikesByAuthorReviewQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Get all author review dislikes belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReviewDislike/UserId/{UserId}
        ///     
        ///     /AuthorReviewDislike/UserId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author review dislikes belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author review dislikes belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("UserId/{UserId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewDislikeDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewDislikesByUserId([FromRoute] GetAuthorReviewDislikesByUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Create a new author review dislikes
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Author
        ///     
        ///     {
        ///         "authorReviewId": "6729df32-c197-4b42-8b58-d88e1c202346",
        ///         "userId": "c0385818-0ea3-4e64-aede-00a6ac1d4f7a"
        ///     }
        ///
        /// </remarks>
        /// <returns>The created author review dislikes</returns>
        /// <response code="200">Returns the created author review dislikes</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AuthorReviewDislikeDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorReviewDislikeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author review dislikes provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorReviewDislike/{Id}
        ///     
        ///     /AuthorReviewDislike/08c6b198-c710-42b6-b237-9c3ed087bd3c
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(AuthorReviewDislikeDto), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorReviewDislikeCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
