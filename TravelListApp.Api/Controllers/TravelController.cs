using Microsoft.AspNetCore.Mvc;

namespace TravelListApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TravelController : Controller
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Get All Travels");
    }
}