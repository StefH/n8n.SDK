namespace n8n.SDK.Models;

public class Project
{
    /// <summary>
    /// Project name.
    /// </summary>
    public required string Name { get; init; }

    public string? Id { get; set; }

    public string? Type { get; set; }
}