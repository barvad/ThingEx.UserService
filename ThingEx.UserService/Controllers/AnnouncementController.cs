using Microsoft.AspNetCore.Mvc;
using ThingEx.UserService.Core;
using ThingEx.UserService.Core.Contracts.Services;

namespace ThingEx.UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class AnnouncementController : ControllerBase
{
    private static readonly string[] Summaries =
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IAnnouncementService _announcementService;

    private readonly ILogger<AnnouncementController> _logger;

    public AnnouncementController(ILogger<AnnouncementController> logger,
        IAnnouncementService announcementService)
    {
        _logger = logger;
        _announcementService = announcementService;
    }

    [HttpGet(Name = "GetAnnouncements")]
    public IEnumerable<Announcement> Get()
    {
        return _announcementService.GetAnnouncements();
    }
}