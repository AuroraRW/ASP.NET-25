using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
