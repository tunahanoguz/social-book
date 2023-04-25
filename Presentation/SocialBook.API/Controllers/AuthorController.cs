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

        [HttpGet]
        public async Task<IActionResult> GetAuthorById([FromQuery] GetAuthorByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("FirstName")]
        public async Task<IActionResult> GetAuthorsByFirstName([FromQuery] GetAuthorsByFirstNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
