using Microsoft.AspNetCore.Mvc;
using ThingEx.UserService.Core;

namespace ThingEx.UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class AnnouncementController : ControllerBase
{
    private static readonly string[] Summaries =
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<AnnouncementController> _logger;

    public AnnouncementController(ILogger<AnnouncementController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAnnouncements")]
    public IEnumerable<Announcement> Get()
    {
        return Array.Empty<Announcement>();
    }
}