namespace n8n.SDK.Models;

public class Credential
{
    /// <summary>
    /// Name of this credential.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Node credential type name.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Credential data.
    /// </summary>
    public required object Data { get; init; }

    /// <summary>
    /// Credential ID (read-only)
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// Created at (read-only)
    /// </summary>
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// Last updated at (read-only)
    /// </summary>
    public DateTime? UpdatedAt { get; init; }
}