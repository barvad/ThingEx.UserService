using Microsoft.EntityFrameworkCore;

namespace ThingEx.UserService.DatabaseContext;

public sealed class UserServiceDbContext : DbContext
{
    public UserServiceDbContext()
    {

    }
    public UserServiceDbContext(DbContextOptions<UserServiceDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Announcement> Announcements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AnnouncementEntityConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}