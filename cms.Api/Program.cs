using cms.core.Interface.Repository;
using cms.Infrastructure.Data;
using cms.Infrastructure.Data.Repositoreis;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<cmsdbcontext>(options=>options.UseSqlServer(
    builder.Configuration.GetConnectionString("CmsDatabase")));
var app = builder.Build();
builder.Services.AddScoped<IpostRepository,PostRepository>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
