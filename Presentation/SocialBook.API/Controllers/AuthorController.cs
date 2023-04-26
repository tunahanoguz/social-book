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
    }
}
