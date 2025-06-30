using Microsoft.EntityFrameworkCore;
using RecuperacaoAPI.Data;
using RecuperacaoAPI.Models;
using RecuperacaoAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddScoped<ILancamentoRepositorio, LancamentoRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}



app.UseAuthorization();
app.MapControllers();
app.Run();
