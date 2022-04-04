using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using CurriculumApi.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Syllabi") ?? "Data Source=Syllabi.db";

builder.Services.AddEndpointsApiExplorer();

// builder.Services.AddDbContext<SyllabusDb>(options => options.UseInMemoryDatabase("items"));
builder.Services.AddSqlite<SyllabusDb>(connectionString);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Curriculum API",
        Description = "",
        Version = "V1"
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Curriculum API V1");
});

app.MapGet("/", () => "Hello World!");
app.MapGet("/syllabi", async (SyllabusDb db) => await db.Syllabi.ToListAsync());

app.Run();
