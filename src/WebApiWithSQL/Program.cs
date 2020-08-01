using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebApiWithSQL
{
    // When the application starts, the Main method, from the Program class, is called.
    // It creates a default web host using the startup configuration, exposing the application via HTTP 
    // through a specific port (by default, port 5000 for HTTP and 5001 for HTTPS).
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
