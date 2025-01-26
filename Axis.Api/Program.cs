using Autofac.Core;
using Autofac;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Autofac.Extensions.DependencyInjection;
using Axis.DataAccess.Persistence;
using Axis.DataAccess;
using Swashbuckle.AspNetCore.Swagger;
using Axis.Application;
using Axis.Application.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AxisDbContext>(options =>
    options.UseNpgsql(connectionString, (x) => x.MigrationsAssembly("Axis.DataAccess")).UseLowerCaseNamingConvention());

// Autofac Integration
builder.Services.AddControllers().AddControllersAsServices();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new DataAccessModule());
    containerBuilder.RegisterModule(new ApplicationModule());
});

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Axis_API v1");
        c.RoutePrefix = string.Empty;
    });
}
//if (app.Environment.IsDevelopment())
//{
//    app.MapScalarApiReference();
//    app.MapOpenApi();
//    app.UseSwagger();
//    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your_API_Name v1"));
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
