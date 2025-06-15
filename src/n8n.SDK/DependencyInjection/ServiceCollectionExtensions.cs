using Microsoft.Extensions.Configuration;
using n8n.SDK.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Stef.Validation;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[PublicAPI]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNodemationSDK(this IServiceCollection services, IConfiguration configuration)
    {
        Guard.NotNull(services);
        Guard.NotNull(configuration);

        return services.AddNodemationSDK(options =>
        {
            configuration.GetSection(nameof(NodemationSDKOptions)).Bind(options);
        });
    }

    public static IServiceCollection AddNodemationSDK(this IServiceCollection services, IConfigurationSection section)
    {
        Guard.NotNull(services);
        Guard.NotNull(section);

        return services.AddNodemationSDK(section.Bind);
    }

    public static IServiceCollection AddNodemationSDK(this IServiceCollection services, Action<NodemationSDKOptions> configureAction)
    {
        Guard.NotNull(services);
        Guard.NotNull(configureAction);

        var options = new NodemationSDKOptions();
        configureAction(options);

        return services.AddNodemationSDK(options);
    }

    public static IServiceCollection AddNodemationSDK(this IServiceCollection services, NodemationSDKOptions options)
    {
        Guard.NotNull(services);
        Guard.NotNull(options);

        var jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        return services.UseWithAuthenticatedRestEaseClient(options, restClient => restClient.JsonSerializerSettings = jsonSerializerSettings);
    }
}