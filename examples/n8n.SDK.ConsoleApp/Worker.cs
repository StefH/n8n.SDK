using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace n8n.SDK.ConsoleApp;

internal class Worker(INodemationApi api, ILogger<Worker> logger)
{
    public async Task RunAsync(CancellationToken cancellationToken = default)
    {
        var workflows = await api.GetWorkflowsAsync(active: true, cancellationToken: cancellationToken);
        foreach (var flow in workflows.Data)
        {
            logger.LogInformation("Flow: {flow}", ToJson(flow));
        }
    }

    private static string ToJson(object value)
    {
        return JsonConvert.SerializeObject(value, Formatting.Indented);
    }
}