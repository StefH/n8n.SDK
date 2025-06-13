namespace n8n.SDK.Models;

public class Role
{
    /// <summary>
    /// Time the role was created.
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Last time the role was updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Scope { get; set; }
}