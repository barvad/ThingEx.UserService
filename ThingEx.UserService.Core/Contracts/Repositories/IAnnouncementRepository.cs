namespace ThingEx.UserService.Core.Contracts.Repositories;

public interface IAnnouncementRepository
{
    void AddAnnouncement(Announcement announcement);
    IEnumerable<Announcement> GetAnnouncements();
}