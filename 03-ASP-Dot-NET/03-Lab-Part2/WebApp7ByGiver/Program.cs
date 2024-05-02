using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp7ByGiver.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// *********** Add connection string and DB Context ************
string conStr = builder.Configuration.GetConnectionString("myConStr");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conStr));

// ********** Configure Identity **********
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
 .AddEntityFrameworkStores<AppDbContext>()
 .AddDefaultTokenProviders();

//  ************ Add Authentication *************
builder.Services.AddAuthentication();

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
// ****************** Use Authentication *******************
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
