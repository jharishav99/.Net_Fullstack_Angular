

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

// User Story 1 & 2: Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});

// User Story 2: Custom Error Handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// User Story 4: Enforce HTTPS and Security
app.UseHttpsRedirection();

// User Story 3: Serve Static Files (from wwwroot)
app.UseStaticFiles();

// User Story 4: Content Security Policy (CSP)
app.Use(async (context, next) =>
{
    // Adding the CSP header to the response
    context.Response.Headers.Append("Content-Security-Policy", "default-src 'self';");
    await next();
});

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();