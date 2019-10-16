using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

using Network.Models;

namespace Network
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(config =>
                {
                    config.ClearProviders();
                    config.AddConsole();
                    config.AddDebug();
                    config.SetMinimumLevel(LogLevel.Warning);
                });
            
    }
}
