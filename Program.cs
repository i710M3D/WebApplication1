global using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Db;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHumanService, HumanService>();
builder.Services.AddDbContext<DataContext>(options => options.UseMySQL("server=127.0.0.1;port=3306;database=Human;user=root;password=D0pe@fuck"));

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
