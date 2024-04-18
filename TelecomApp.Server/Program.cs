using Microsoft.EntityFrameworkCore;
using TelecomApp.Server;

var builder = WebApplication.CreateBuilder(args);

// EntityFramework Core initialize
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
builder.Services.AddDbContext<ServerContext>(options => options.UseNpgsql(connectionString));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<ServerContext>();
await db.Database.EnsureCreatedAsync();

app.Run();
