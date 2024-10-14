using Microsoft.EntityFrameworkCore;
using ThingEx.UserService.Core.Contracts.Repositories;
using ThingEx.UserService.Core.Contracts.Services;
using ThingEx.UserService.Core.Services;
using ThingEx.UserService.DatabaseContext;
using ThingEx.UserService.Extensions;
using ThingEx.UserService.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddShardInfo();

builder.Services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
builder.Services.AddScoped<IAnnouncementService, AnnouncementService>();
var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
var connectionString = builder.Configuration.GetConnectionString("Postgres") ??
                       throw new NullReferenceException("Connection string not specified! (Postgres)");
connectionString = isDevelopment
    ? connectionString.Replace("${HOST}", "localhost")
        .Replace("${PASSWORD}", "P@ssword")
    : connectionString.Replace("${HOST}", Environment.GetEnvironmentVariable("db_host"))
        .Replace("${PASSWORD}", Environment.GetEnvironmentVariable("db_pass"));
builder.Services.AddDbContext<UserServiceDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

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