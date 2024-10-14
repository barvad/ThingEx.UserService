using ThingEx.UserService.Core.Contracts.Repositories;
using ThingEx.UserService.DatabaseContext;
using Announcement = ThingEx.UserService.Core.Announcement;

namespace ThingEx.UserService.Repositories;

public class AnnouncementRepository : IAnnouncementRepository
{
    private readonly UserServiceDbContext _dbContext;

    public AnnouncementRepository(UserServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddAnnouncement(Announcement announcement)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Announcement> GetAnnouncements()
    {
        return _dbContext.Announcements.Select(a => new Announcement
        {
            Id = a.Id,
            Text = a.Text,
            Title = a.Title
        });
    }
}