using Microsoft.EntityFrameworkCore;
using HealthMonitorApp.Models;
using HealthMonitorApp.Services;

var builder = WebApplication.CreateBuilder(args);
// Register HealthService as Scoped
builder.Services.AddScoped<HealthService>();

// Add services to the container.
builder.Services.AddDbContext<HealthMonitorDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HealthDbConnection"))
);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
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
