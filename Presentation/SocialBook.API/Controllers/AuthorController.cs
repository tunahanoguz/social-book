using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.Features;
using SocialBook.Application.Features.Authors;

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

        [HttpGet("{AuthorId}")]
        public async Task<IActionResult> GetAuthorById([FromRoute] GetAuthorByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("FirstName/{FirstName}")]
        public async Task<IActionResult> GetAuthorsByFirstName([FromRoute] GetAuthorsByFirstNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("LastName/{LastName}")]
        public async Task<IActionResult> GetAuthorsByLastName([FromRoute] GetAuthorsByLastNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("CountryOfBirth/{CountryOfBirth}")]
        public async Task<IActionResult> GetAuthorsByCountryOfBirth([FromRoute] GetAuthorsByCountryOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("YearOfBirth/{YearOfBirth}")]
        public async Task<IActionResult> GetAuthorsByYearOfBirth([FromRoute] GetAuthorsByYearOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("AllowedReview")]
        public async Task<IActionResult> GetAuthorsAllowedReview()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedReviewQueryRequest());
            return Ok(response);
        }

        [HttpGet("NotAllowedReview")]
        public async Task<IActionResult> GetAuthorsNotAllowedReview()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedReviewQueryRequest());
            return Ok(response);
        }

        [HttpGet("AllowedRecommendation")]
        public async Task<IActionResult> GetAuthorsAllowedRecommendation()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        [HttpGet("NotAllowedRecommendation")]
        public async Task<IActionResult> GetAuthorsNotAllowedRecommendation()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        [HttpGet("AllowedSubscription")]
        public async Task<IActionResult> GetAuthorsAllowedSubscription()
        {
            var response = await _mediator.Send(new GetAuthorsAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        [HttpGet("AllowedNotSubscription")]
        public async Task<IActionResult> GetAuthorsNotAllowedSubscription()
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        [HttpGet("CreatorUser/{CreatorUserId}")]
        public async Task<IActionResult> GetAuthorsByCreatorUser([FromRoute] GetAuthorsByCreatorUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor([FromBody] UpdateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
