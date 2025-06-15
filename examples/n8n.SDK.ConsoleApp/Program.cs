using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace n8n.SDK.ConsoleApp;

static class Program
{
    static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(theme: AnsiConsoleTheme.Code)
            .CreateLogger();

        await using var serviceProvider = RegisterServices(args);

        var worker = serviceProvider.GetRequiredService<Worker>();

        await worker.RunAsync();
    }

    private static ServiceProvider RegisterServices(string[] args)
    {
        var configuration = SetupConfiguration(args);
        var services = new ServiceCollection();

        services.AddSingleton(configuration);
        
        services.AddLogging(builder => builder.AddSerilog(logger: Log.Logger, dispose: true));

        services.AddNodemationSDK(configuration);

        services.AddSingleton<Worker>();

        return services.BuildServiceProvider();
    }

    private static IConfiguration SetupConfiguration(string[] args)
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();
    }
}