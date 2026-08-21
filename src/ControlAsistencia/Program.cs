var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


var app = builder.Build();
app.MapControllers();

app.MapGet("/api/ping", () => new { Message = "Ping de prueba" });

app.Run();
