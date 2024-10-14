namespace ThingEx.UserService.Core;

public class Announcement
{
    public ulong Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}