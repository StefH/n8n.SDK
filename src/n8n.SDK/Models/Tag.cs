namespace n8n.SDK.Models;

public class Tag
{
    /// <summary>
    /// Tag name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Tag ID (read-only)
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Created at (read-only)
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Updated at (read-only)
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}