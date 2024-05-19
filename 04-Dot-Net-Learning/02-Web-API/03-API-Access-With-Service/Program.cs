using _03_API_Access_With_Service.Controllers.Service;
using _03_API_Access_With_Service.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ************* Add HttpClient service using DI and JSON Service( No need to add HttpClient Name) ******************
// ************* The JSON Service uses the JSON Response Model inside it ***********
builder.Services.AddHttpClient<MyJsonService>(x =>
    x.BaseAddress = new Uri("https://api.open-meteo.com")
); 

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
