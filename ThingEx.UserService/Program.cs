using ThingEx.UserService.Core;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
ShardInfo.UserFromId = app.Environment.IsDevelopment()
    ? 0
    : int.Parse(Environment.GetEnvironmentVariable("user_from_id")
                ?? throw new ArgumentException("Not specified variable 'user_from_id'"));

ShardInfo.UserToId = app.Environment.IsDevelopment()
    ? 1000000
    : int.Parse(Environment.GetEnvironmentVariable("user_to_id")
                ?? throw new ArgumentException("Not specified variable 'user_to_id'"));
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
