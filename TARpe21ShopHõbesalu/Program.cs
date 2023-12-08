using Microsoft.EntityFrameworkCore;
using TARpe21ShopH�besalu.ApplicationServices.Services;
using TARpe21ShopH�besalu.Core.ServiceInterface;
using TARpe21ShopH�besalu.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TARpe21ShopH�besaluContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISpaceshipsServices, SpaceshipsServices>();
builder.Services.AddScoped<IFilesServices, FilesServices>();
builder.Services.AddScoped<IRealEstatesServices, RealEstatesServices>();
builder.Services.AddScoped<IWeatherForecastsServices, WeatherForecastsServices>();

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