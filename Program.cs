using Microsoft.EntityFrameworkCore;
using CrudProjeto.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração da conexão com o banco de dados no Somee
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers(); // <--- ADICIONADO
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers(); // <--- ADICIONADO

app.Run();
