using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Features.Commands;
using SocialBook.Infrastructure.Results;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get the author with the identifier provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/{Id}
        ///     
        ///     /Author/a1cf5611-cf6a-4c46-99cf-4fe34c71a893
        ///
        /// </remarks>
        /// <returns>The author with the identifier provided as a parameter</returns>
        /// <response code="200">Returns the author with the identifier provided as a parameter</response>
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(GetAuthorByFirstNameQueryResponse), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorById([FromRoute] GetAuthorByIdQueryRequest request)
        {
            var result = new BaseResult(System.Net.HttpStatusCode.NotFound, "asdasdas");



            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors with the first name provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/FirstName/{FirstName}
        ///     
        ///     /Author/FirstName/Charles
        ///
        /// </remarks>
        /// <returns>All authors with the first name provided as a parameter</returns>
        /// <response code="200">Returns all authors with the first name provided as a parameter</response>
        [HttpGet("FirstName/{FirstName}")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsByFirstNameQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsByFirstName([FromRoute] GetAuthorsByFirstNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/LastName/{LastName}
        ///     
        ///     /Author/LastName/Dickens
        ///
        /// </remarks>
        /// <returns>All authors with the last name provided as a parameter</returns>
        /// <response code="200">Returns all authors with the last name provided as a parameter</response>
        [HttpGet("LastName/{LastName}")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsByLastNameQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsByLastName([FromRoute] GetAuthorsByLastNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/CountryOfBirth/{CountryOfBirth}
        ///     
        ///     /Author/CountryOfBirth/United Kingdom
        ///
        /// </remarks>
        /// <returns>All authors born in the country provided as a parameter</returns>
        /// <response code="200">Returns all authors born in the country provided as a parameter</response>
        [HttpGet("CountryOfBirth/{CountryOfBirth}")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsByCountryOfBirthQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsByCountryOfBirth([FromRoute] GetAuthorsByCountryOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/YearOfBirth/{YearOfBirth}
        ///     
        ///     /Author/YearOfBirth/1812
        ///
        /// </remarks>
        /// <returns>All authors born in the year provided as a parameter</returns>
        /// <response code="200">Returns all authors born in the year provided as a parameter</response>
        [HttpGet("YearOfBirth/{YearOfBirth}")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsByYearOfBirthQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsByYearOfBirth([FromRoute] GetAuthorsByYearOfBirthQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/AllowedReview
        ///     
        ///     /Author/AllowedReview
        ///
        /// </remarks>
        /// <returns>All authors allowed to have reviews published about them</returns>
        /// <response code="200">Returns all authors allowed to have reviews published about them</response>
        [HttpGet("AllowedReview")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsAllowedReviewQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsAllowedReview([FromRoute] GetAuthorsAllowedReviewQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsAllowedReviewQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/NotAllowedReview
        ///     
        ///     /Author/NotAllowedReview
        ///
        /// </remarks>
        /// <returns>All authors not allowed to have reviews published about them</returns>
        /// <response code="200">Returns all authors not allowed to have reviews published about them</response>
        [HttpGet("NotAllowedReview")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsNotAllowedReviewQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsNotAllowedReview([FromRoute] GetAuthorsNotAllowedReviewQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedReviewQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/AllowedRecommendation
        ///     
        ///     /Author/AllowedRecommendation
        ///
        /// </remarks>
        /// <returns>All authors allowed to be recommended by users to other users</returns>
        /// <response code="200">Returns all authors allowed to be recommended by users to other users</response>
        [HttpGet("AllowedRecommendation")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsAllowedRecommendationQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsAllowedRecommendation([FromRoute] GetAuthorsAllowedRecommendationQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/NotAllowedRecommendation
        ///     
        ///     /Author/NotAllowedRecommendation
        ///
        /// </remarks>
        /// <returns>All authors not allowed to be recommended by users to other users</returns>
        /// <response code="200">Returns all authors not allowed to be recommended by users to other users</response>
        [HttpGet("NotAllowedRecommendation")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsNotAllowedRecommendationQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsNotAllowedRecommendation([FromRoute] GetAuthorsNotAllowedRecommendationQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedRecommendationQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/AllowedSubscription
        ///     
        ///     /Author/AllowedSubscription
        ///
        /// </remarks>
        /// <returns>All authors who are allowed to be subscribed to by users</returns>
        /// <response code="200">Returns all authors who are allowed to be subscribed to by users</response>
        [HttpGet("AllowedSubscription")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsAllowedSubscriptionQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsAllowedSubscription([FromRoute] GetAuthorsAllowedSubscriptionQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/NotAllowedSubscription
        ///     
        ///     /Author/NotAllowedSubscription
        ///
        /// </remarks>
        /// <returns>All authors who are not allowed to be subscribed to by users</returns>
        /// <response code="200">Returns all authors who are not allowed to be subscribed to by users</response>
        [HttpGet("NotAllowedSubscription")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsNotAllowedSubscriptionQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsNotAllowedSubscription([FromRoute] GetAuthorsNotAllowedSubscriptionQueryRequest request)
        {
            var response = await _mediator.Send(new GetAuthorsNotAllowedSubscriptionQueryRequest());
            return Ok(response);
        }

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Author/CreatorUser/{CreatorUserId}
        ///     
        ///     /Author/CreatorUser/92088e43-474e-4bd6-9dbe-cfc5293e885f
        ///
        /// </remarks>
        /// <returns>All authors belonging to the user whose ID is provided as a parameter</returns>
        /// <response code="200">Returns all authors belonging to the user whose ID is provided as a parameter</response>
        [HttpGet("CreatorUser/{CreatorUserId}")]
        [ProducesResponseType(typeof(IEnumerable<GetAuthorsByCreatorUserQueryResponse>), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> GetAuthorsByCreatorUser([FromRoute] GetAuthorsByCreatorUserQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Create a new author
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Author
        ///     
        ///     {
        ///         "firstName": "Ernest",
        ///         "lastName": "Hemingway",
        ///         "description": "The description about Ernest Hemingway.",
        ///         "countryOfBirth": "The United States",
        ///         "dateOfBirth": "1899-07-21T06:06:38.723Z",
        ///         "metaTitle": "Ernest Hemingway",
        ///         "metaDescription": "The meta description about Ernest Hemingway.",
        ///         "metaKeywords": "ernest hemingway author, ernest hemingway books",
        ///         "slug": "ernest-hemingway",
        ///         "isAllowedReview": true,
        ///         "isAllowedRecommendation": true,
        ///         "isAllowedSubscription": true,
        ///         "creatorUserId": "92088e43-474e-4bd6-9dbe-cfc5293e885f"
        ///     }
        ///
        /// </remarks>
        /// <returns>The created author</returns>
        /// <response code="200">Returns the created author</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(CreateAuthorQueryResponse), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Update the author provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Author
        ///     
        ///     {
        ///         "id": "2823add5-60f3-4272-9ec1-087d69cca72c",
        ///         "firstName": "Updated Ernest",
        ///         "lastName": "Updated Hemingway",
        ///         "description": "The description about updated Ernest Hemingway.",
        ///         "countryOfBirth": "The United States",
        ///         "dateOfBirth": "1899-07-21T06:06:38.723Z",
        ///         "metaTitle": "Ernest Hemingway",
        ///         "metaDescription": "The meta description about updated Ernest Hemingway.",
        ///         "metaKeywords": "ernest hemingway author, ernest hemingway books",
        ///         "slug": "ernest-hemingway",
        ///         "isAllowedReview": true,
        ///         "isAllowedRecommendation": true,
        ///         "isAllowedSubscription": true,
        ///         "creatorUserId": "92088e43-474e-4bd6-9dbe-cfc5293e885f"
        ///     }
        ///
        /// </remarks>
        /// <returns>The updated author</returns>
        /// <response code="200">Returns the updated author</response>
        [HttpPut]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(UpdateAuthorQueryResponse), StatusCodes.Status200OK, "application/json")]
        public async Task<IActionResult> UpdateAuthor([FromBody] UpdateAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Delete the author provided as a parameter
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Author/{Id}
        ///     
        ///     /Author/a1cf5611-cf6a-4c46-99cf-4fe34c71a893
        ///
        /// </remarks>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
