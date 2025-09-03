using Microsoft.EntityFrameworkCore;
// using YourNamespace.Models; // whatever namespace your DbContext is in
using lab_10_albertspencer.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Apply any pending migrations automatically on startup (dev-only convenience)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ProductContext>();
    db.Database.Migrate();  // creates DB and tables if they don't exist
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
