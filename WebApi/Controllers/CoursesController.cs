using Business.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    Context context = new Context();

    [HttpGet("price")]
    public IActionResult GetPrice(int userId, int courseId)
    {
        var price = context.GetPrice(userId, courseId);
        return Ok(price);
    }
}
