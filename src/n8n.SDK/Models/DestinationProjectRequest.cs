namespace n8n.SDK.Models;

public class DestinationProjectRequest
{
    /// <summary>
    /// The ID of the project to transfer the workflow to.
    /// </summary>
    public required string DestinationProjectId { get; init; }
}