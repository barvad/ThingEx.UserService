using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThingEx.UserService.DatabaseContext;

public class AnnouncementEntityConfiguration : IEntityTypeConfiguration<Announcement>
{
    public void Configure(EntityTypeBuilder<Announcement> builder)
    {
        builder.ToTable("Announcements");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Title).HasMaxLength(500);
        builder.Property(p => p.Text).HasMaxLength(5000);

    }
}