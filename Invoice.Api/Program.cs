global using Microsoft.AspNetCore.Mvc;
global using Invoice.Core.Models;
global using Invoice.Core.Interfaces;
global using Microsoft.EntityFrameworkCore;
global using Invoice.Infrastructure;
global using Invoice.Core;
global using AutoMapper;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration, builder.Environment);


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
