using Microsoft.EntityFrameworkCore;
using RateForProfessor.Context;
using RateForProfessor.Repositories;
using RateForProfessor.Repositories.Interfaces;
using RateForProfessor.Services.Interfaces;
using RateForProfessor.Services;
using FluentValidation.AspNetCore;
using System.Reflection;
using AutoMapper;
using System.Xml.Linq;
using RateForProfessor.Mappings;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers().AddFluentValidation(c => c.RegisterValidatorsFromAssembly
                       // (Assembly.GetExecutingAssembly()));

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("DefaultConnection");
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(UserProfileMapping));
builder.Services.AddScoped<IUserRegistrationRepository, UserRegistrationRepository>();
builder.Services.AddScoped<IUserRegistrationService, UserRegistrationService>();

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
