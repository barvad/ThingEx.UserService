using ThingEx.UserService.Core;

namespace ThingEx.UserService.Extensions;

public static class AddShardInfoExtensions
{
    public static void AddShardInfo(this IServiceCollection services)
    {
        var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        services.AddSingleton<ShardInfo>(x => new ShardInfo
        {
            UserFromId = isDevelopment
                ? 0
                : int.Parse(Environment.GetEnvironmentVariable("user_from_id")
                            ?? throw new ArgumentException("Not specified variable 'user_from_id'")),
            UserToId = isDevelopment
                ? 1000000
                : int.Parse(Environment.GetEnvironmentVariable("user_to_id")
                            ?? throw new ArgumentException("Not specified variable 'user_to_id'"))
        });
    }
}