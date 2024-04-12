using _06_ORM_App.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Declare connection string from appsetting.json
var conStr = builder.Configuration.GetConnectionString("myConStr");

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add DB Context with Connection String
builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(conStr));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
