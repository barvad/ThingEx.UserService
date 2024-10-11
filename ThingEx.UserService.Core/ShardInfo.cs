namespace ThingEx.UserService.Core
{
    public static class ShardInfo
    {
        public static int UserFromId { get; set; }
        public static int UserToId { get; set; }
        public static string ShardName => $"users{UserFromId}_{UserToId}";
    }
}
