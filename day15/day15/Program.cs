using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using day15.Data;    // Context for Identity
using day15.Models;  // Context for App Data (Step 6)

var builder = WebApplication.CreateBuilder(args);

// --- STEP 8: ADD 3 EXTRA BLOCKS ---

// 1. Connection for Identity (Login/Register)
var authConnectionString = builder.Configuration.GetConnectionString("AuthConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(authConnectionString));

// 2. Connection for App Data (Class Library Models)
var appDataConnectionString = builder.Configuration.GetConnectionString("AppDataConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(appDataConnectionString));

// 3. Identity Configuration with Roles
builder.Services.AddDefaultIdentity<IdentityUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false; // Easier for testing
    options.Password.RequiredLength = 6;
})
.AddRoles<IdentityRole>() // Requirement from professor's Step 8
.AddEntityFrameworkStores<ApplicationDbContext>();

// Add services for MVC
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// REQUIRED FOR LOGIN TO WORK
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // Needed for Identity pages

app.Run();