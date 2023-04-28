using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SocialBook.Application.Results;
using System.Net;

namespace SocialBook.API.Extensions
{
    /// <summary>
    /// Represent all extensions for ControllerBase
    /// </summary>
    public static class ControllerBaseExtensions
    {
        /// <summary>
        /// Returns different types of results based on HTTP status code
        /// </summary>
        /// <param name="controllerBase">The ConrollerBase class</param>
        /// <param name="result">The base result of all controller actions</param>
        /// <returns></returns>
        public static IActionResult GetResult(this ControllerBase controllerBase, IBaseResult result)
        {
            switch (result.StatusCode)
            {
                case (int)HttpStatusCode.OK:
                    {
                        return new OkObjectResult(result);
                    }
                case (int)HttpStatusCode.Created:
                    {
                        var uri = (controllerBase.HttpContext.Request).GetDisplayUrl();
                        return new CreatedResult(uri, result);
                    }
                case (int)HttpStatusCode.NotFound:
                    {
                        return new NotFoundObjectResult(result);
                    }
                case (int)HttpStatusCode.NoContent:
                    {
                        return new NoContentResult();
                    }
                case (int)HttpStatusCode.Forbidden:
                    {
                        return new ForbidResult();
                    }
                case (int)HttpStatusCode.Unauthorized:
                    {
                        return new UnauthorizedResult();
                    }
                default:
                    {
                        return new BadRequestObjectResult(result);
                    }
            }
        }
    }
}
