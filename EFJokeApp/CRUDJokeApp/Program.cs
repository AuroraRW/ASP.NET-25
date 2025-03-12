using CRUDJokeApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<JokeDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));
var app = builder.Build();

app.MapControllers();
app.Run();
