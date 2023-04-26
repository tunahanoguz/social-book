using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Features.Commands;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get the author with the identifier provided as a parameter
        /// </summary>
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAuthorById([FromRoute] GetAuthorByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors with the first name provided as a parameter
        /// </summary>
        [HttpGet("FirstName/{FirstName}")]
        public async Task<IActionResult> GetAuthorsByFirstName([FromRoute] GetAuthorsByFirstNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        [HttpGet("LastName/{LastName}")]
        public async Task<IActionResult> GetAuthorsByLastName([FromRoute] GetAuthorsByLastNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        [HttpGet("CountryOfBirth/{CountryOfBirth}")]
        public async Task<IActionResult> GetAuthorsByCountryOfBirth([FromRoute] GetAuthorsByCountryOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        [HttpGet("YearOfBirth/{YearOfBirth}")]
        public async Task<IActionResult> GetAuthorsByYearOfBirth([FromRoute] GetAuthorsByYearOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        [HttpGet("AllowedReview")]
        public async Task<IActionResult> GetAuthorsAllowedReview()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedReviewQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        [HttpGet("NotAllowedReview")]
        public async Task<IActionResult> GetAuthorsNotAllowedReview()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedReviewQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        [HttpGet("AllowedRecommendation")]
        public async Task<IActionResult> GetAuthorsAllowedRecommendation()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        [HttpGet("NotAllowedRecommendation")]
        public async Task<IActionResult> GetAuthorsNotAllowedRecommendation()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        [HttpGet("AllowedSubscription")]
        public async Task<IActionResult> GetAuthorsAllowedSubscription()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        [HttpGet("AllowedNotSubscription")]
        public async Task<IActionResult> GetAuthorsNotAllowedSubscription()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        [HttpGet("CreatorUser/{CreatorUserId}")]
        public async Task<IActionResult> GetAuthorsByCreatorUser([FromRoute] GetAuthorsByCreatorUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Create a new author
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Update the author provided as a parameter
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor([FromBody] UpdateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Delete the author provided as a parameter
        /// </summary>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
