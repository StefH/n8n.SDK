namespace n8n.SDK.Models;

public class ProjectUserRelationItem
{
    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// The role assigned to the user in the project.
    /// </summary>
    public required string Role { get; init; }
}