using CleanArchitecture.Application;
using CleanArchitecture.Infra;
using CleanArchitecture.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

// Add services to the container.

// add layer dependencies
builder.Services.AddApplicationServices();
builder.Services.AddRegisteredServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
// Read connection string from configuration
string defaultConnection = config.GetConnectionString("DefaultConnection");

// Add DbContext to services
builder.Services.AddDbContext<ApplicationDataContext>(options =>
    options.UseMySql(defaultConnection, ServerVersion.AutoDetect(defaultConnection)));

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
