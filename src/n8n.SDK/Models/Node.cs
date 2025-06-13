namespace n8n.SDK.Models;

public class Node
{
    public string? Id { get; set; }

    public required string Name { get; init; }

    public string? WebhookId { get; set; }

    public bool? Disabled { get; set; }

    public bool? NotesInFlow { get; set; }

    public string? Notes { get; set; }

    /// <summary>
    /// Node type, e.g. n8n-nodes-base.Jira
    /// </summary>
    public required string Type { get; init; }

    public decimal? TypeVersion { get; set; }

    public bool? ExecuteOnce { get; set; }

    public bool? AlwaysOutputData { get; set; }

    public bool? RetryOnFail { get; set; }

    public decimal? MaxTries { get; set; }

    public decimal? WaitBetweenTries { get; set; }

    /// <summary>
    /// use onError instead
    /// </summary>
    public bool? ContinueOnFail { get; set; }

    public string? OnError { get; set; }

    public List<decimal>? Position { get; set; }

    public object? Parameters { get; set; }

    public object? Credentials { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}