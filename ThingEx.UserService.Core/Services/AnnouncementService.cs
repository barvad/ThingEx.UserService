using ThingEx.UserService.Core.Contracts.Repositories;
using ThingEx.UserService.Core.Contracts.Services;

namespace ThingEx.UserService.Core.Services;

public class AnnouncementService : IAnnouncementService
{
    private readonly IAnnouncementRepository _announcementRepository;

    public AnnouncementService(IAnnouncementRepository announcementRepository)
    {
        _announcementRepository = announcementRepository;
    }

    public void AddAnnouncement(Announcement announcement)
    {
        _announcementRepository.AddAnnouncement(announcement);
    }

    public IEnumerable<Announcement> GetAnnouncements()
    {
        return _announcementRepository.GetAnnouncements();
    }
}