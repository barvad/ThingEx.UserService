namespace ThingEx.UserService.Core;

public class ShardInfo
{
    public int UserFromId { get; set; }
    public int UserToId { get; set; }
    public string ShardName => $"users{UserFromId}_{UserToId}";
}