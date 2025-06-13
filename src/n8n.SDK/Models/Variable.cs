namespace n8n.SDK.Models;

public class Variable
{
    /// <summary>
    /// Variable key.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// Variable value.
    /// </summary>
    public required string Value { get; init; }

    public string? Id { get; set; }

    public string? Type { get; set; }
}