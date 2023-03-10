using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
.AddJsonOptions(options => options.JsonSerializerOptions
.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json")
.Build();

builder.Services.AddDbContext<FreshAPI.Models.FreshDbContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("FreshDb"))
    );


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
