using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorReviewLikeController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorReviewLikeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all author review likes belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReviewLike/AuthorReviewId/{AuthorReviewId}
        ///     
        ///     /AuthorReviewLike/AuthorReviewId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author review likes belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author review likes belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorReviewId/{AuthorReviewId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewLikeDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewLikesByAuthorReviewId([FromRoute] GetAuthorReviewLikesByAuthorReviewQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Get all author review likes belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReviewLike/UserId/{UserId}
        ///     
        ///     /AuthorReviewLike/UserId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author review likes belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author review likes belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("UserId/{UserId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewLikeDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewLikesByUserId([FromRoute] GetAuthorReviewLikesByAuthorReviewQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Create a new author review likes
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
        /// <returns>The created author review likes</returns>
        /// <response code="200">Returns the created author review likes</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AuthorReviewLikeDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorReviewLikeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author review likes provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorReviewLike/{Id}
        ///     
        ///     /AuthorReviewLike/08c6b198-c710-42b6-b237-9c3ed087bd3c
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(AuthorReviewLikeDto), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorReviewLikeCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
