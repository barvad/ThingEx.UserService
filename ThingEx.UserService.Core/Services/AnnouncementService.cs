using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThingEx.UserService.Core.Contracts.Repositories;
using ThingEx.UserService.Core.Contracts.Services;

namespace ThingEx.UserService.Core.Services
{
    public class AnnouncementService: IAnnouncementService
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
    }
}
