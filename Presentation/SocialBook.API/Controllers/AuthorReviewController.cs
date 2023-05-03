using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorReviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorReviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all author reviews belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReview/AuthorId/{AuthorId}
        ///     
        ///     /AuthorReview/AuthorId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author reviews belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author reviews belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorId/{AuthorId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewsByAuthorId([FromRoute] GetAuthorReviewsByAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Get all author reviews belonging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReview/UserId/{UserId}
        ///     
        ///     /AuthorReview/UserId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author reviews belonging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author reviews belonging to the author whose identifier provided as a parameter</response>
        [HttpGet("UserId/{UserId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewsByUserId([FromRoute] GetAuthorReviewsByUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Get all author reviews by rating
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorReview/Rating/{Rating}
        ///     
        ///     /AuthorReview/Rating/5
        ///
        /// </remarks>
        /// <returns>All author reviews by rating</returns>
        /// <response code="200">Returns all author reviews by rating</response>
        [HttpGet("Rating/{Rating}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorReviewDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorReviewsByRating([FromRoute] GetAuthorReviewsByRatingQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Create a new author review
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Author
        ///     
        ///     {
        ///         "authorId": "6729df32-c197-4b42-8b58-d88e1c202346",
        ///         "ReviewId": "c0385818-0ea3-4e64-aede-00a6ac1d4f7a"
        ///     }
        ///
        /// </remarks>
        /// <returns>The created author review</returns>
        /// <response code="200">Returns the created author review</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AuthorReviewDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorReviewCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author review provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorReview/{Id}
        ///     
        ///     /AuthorReview/08c6b198-c710-42b6-b237-9c3ed087bd3c
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(AuthorReviewDto), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorReviewCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
