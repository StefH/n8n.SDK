namespace n8n.SDK.Models;

public class CreateCredentialResponse
{
    /// <summary>
    /// Credential ID (read-only)
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Name of the credential.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Node credential type.
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// Created at (read-only)
    /// </summary>
    public required DateTime CreatedAt { get; init; }

    /// <summary>
    /// Updated at (read-only)
    /// </summary>
    public required DateTime UpdatedAt { get; init; }
}