namespace n8n.SDK.Models;

public class Workflow
{
    /// <summary>
    /// Name of the workflow.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// List of nodes in this workflow.
    /// </summary>
    public required List<Node> Nodes { get; init; }

    /// <summary>
    /// Connections of this workflow.
    /// </summary>
    public required object Connections { get; init; }

    public required WorkflowSettings Settings { get; init; }

    /// <summary>
    /// Workflow ID (read-only)
    /// </summary>
    public string? Id { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public object? StaticData { get; set; }

    public List<Tag>? Tags { get; set; }
}