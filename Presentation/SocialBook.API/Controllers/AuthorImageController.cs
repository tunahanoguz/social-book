using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialBook.API.Extensions;
using SocialBook.Application.Features.Commands;

namespace SocialBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AuthorId/{AuthorId}")]
        public async Task<IActionResult> CreateAuthorImage([FromRoute] CreateAuthorImageCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return this.GetResult(StatusCodes.Status201Created, response);
        }
    }
}
