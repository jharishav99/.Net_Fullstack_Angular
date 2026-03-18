using Serilog;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup Logging for Task 3 [cite: 31, 62]
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            var userManager = new UserManager();

            // Task 1: Demonstrate Registration [cite: 17, 42]
            userManager.Register("AdminUser", "SecurePass123", "admin@wipro.com");

            // Task 1: Demonstrate Authentication [cite: 19, 48]
            bool isAuth = userManager.Authenticate("AdminUser", "SecurePass123");
            Console.WriteLine($"Authentication Successful: {isAuth}");
        }
        catch (Exception ex)
        {
            // Task 3: Handle exceptions gracefully [cite: 30, 60]
            Log.Error(ex, "An error occurred during application execution");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}