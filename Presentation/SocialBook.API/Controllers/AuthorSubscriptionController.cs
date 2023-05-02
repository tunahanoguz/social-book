using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorSubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorSubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all author subscriptions beloging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorSubscription/AuthorId/{AuthorId}
        ///     
        ///     /AuthorSubscription/AuthorId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author subscriptions beloging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author subscriptions beloging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorId/{AuthorId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorSubscriptionDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorSubscriptionsByAuthorId([FromRoute] GetAuthorSubscriptionsByAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Get all author subscriptions beloging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorSubscription/UserId/{UserId}
        ///     
        ///     /AuthorSubscription/UserId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author subscriptions beloging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author subscriptions beloging to the author whose identifier provided as a parameter</response>
        [HttpGet("UserId/{UserId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorSubscriptionDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorSubscriptionsByUserId([FromRoute] GetAuthorSubscriptionsByUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Create a new author subscription
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Author
        ///     
        ///     {
        ///         "authorId": "6729df32-c197-4b42-8b58-d88e1c202346",
        ///         "SubscriptionId": "c0385818-0ea3-4e64-aede-00a6ac1d4f7a"
        ///     }
        ///
        /// </remarks>
        /// <returns>The created author subscription</returns>
        /// <response code="200">Returns the created author subscription</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AuthorSubscriptionDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorSubscriptionCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author subscription provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorSubscription/{Id}
        ///     
        ///     /AuthorSubscription/08c6b198-c710-42b6-b237-9c3ed087bd3c
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(AuthorSubscriptionDto), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorSubscriptionCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
