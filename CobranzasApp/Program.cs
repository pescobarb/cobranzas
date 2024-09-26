
using CobranzasApp.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configura los servicios
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()   // Permite cualquier origen
                   .AllowAnyMethod()   // Permite cualquier método (GET, POST, etc.)
                   .AllowAnyHeader();  // Permite cualquier cabecera
        });
});

builder.Services.AddControllers(); // Asegúrate de tener configurado el controlador
// Registra el servicio en el contenedor de dependencias

builder.Services.AddSingleton<IClienteService, ClienteService>();

var app = builder.Build();

// Usa la política de CORS
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
