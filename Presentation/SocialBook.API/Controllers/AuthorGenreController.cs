using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.DTOs.Authors.AuthorGenre;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Features.Queries;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorGenreController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorGenreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all author genres beloging to the author whose identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /AuthorGenre/AuthorId/{AuthorId}
        ///     
        ///     /AuthorGenre/AuthorId/022fb7f5-3528-4254-a9b4-b23fb3b2e85a
        ///
        /// </remarks>
        /// <returns>All author genres beloging to the author whose identifier provided as a parameter</returns>
        /// <response code="200">Returns all author genres beloging to the author whose identifier provided as a parameter</response>
        [HttpGet("AuthorId/{AuthorId}")]
        [ProducesResponseType(typeof(PaginatedListDto<AuthorGenreDto>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorGenresByAuthorId([FromRoute] GetAuthorGenresByAuthorIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status200OK, response);
        }

        /// <summary>
        /// Create a new author genre
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Author
        ///     
        ///     {
        ///         "authorId": "6729df32-c197-4b42-8b58-d88e1c202346",
        ///         "genreId": "c0385818-0ea3-4e64-aede-00a6ac1d4f7a"
        ///     }
        ///
        /// </remarks>
        /// <returns>The created author genre</returns>
        /// <response code="200">Returns the created author genre</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AuthorGenreDto), StatusCodes.Status201Created, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorGenreCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }

        /// <summary>
        /// Delete the author genre provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /AuthorGenre/{Id}
        ///     
        ///     /AuthorGenre/08c6b198-c710-42b6-b237-9c3ed087bd3c
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(AuthorGenreDto), StatusCodes.Status204NoContent, "application/json")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorGenreCommandRequest request)
        {
            await _mediator.Send(request);

            return this.GetResult(StatusCodes.Status204NoContent);
        }
    }
}
