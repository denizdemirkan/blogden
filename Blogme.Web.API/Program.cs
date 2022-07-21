using Autofac;
using Autofac.Extensions.DependencyInjection;
using Blogden.Repository.DbContexts;
using Blogden.Service.Mappings;
using Blogme.Web.API.Modules;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<MSSqlDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionString"), option =>
    {
        // Get me Assembly (App) that has SqlServerDbContext in it.
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(MSSqlDbContext)).GetName().Name);
    });
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new DbTransferModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

}

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
