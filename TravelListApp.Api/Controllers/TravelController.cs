using Microsoft.AspNetCore.Mvc;

namespace TravelListApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TravelController : Controller
{
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        return Ok("Get All Travels");
    }

    [HttpGet]
    [Route("{travelId}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] Guid travelId)
    {
        return Ok("Get Travel By Id: " + travelId);
    }
}