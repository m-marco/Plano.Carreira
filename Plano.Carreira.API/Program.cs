using MediatR;
using Microsoft.EntityFrameworkCore;
using Plano.Carreira.Infra;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySQLConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQLConnection")))
);

builder.Services.AddMediatR(
//Assembly.LoadFrom("../Plano.Carreira.CQRS"));
AppDomain.CurrentDomain.Load("Plano.Carreira.CQRS"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
