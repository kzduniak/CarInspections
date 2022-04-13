using CarInspections.Api.Repository;
using CarInspections.Api.Entities;
using CarInspections.Api.Services;
using CarInspections.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using CarInspections.Api.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarInspectionsContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<ICarInspectionsRepository, CarInspectionsRepository>();
builder.Services.AddTransient<ICarInspectionsService, CarInspectionsService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configure app
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();
