namespace n8n.SDK.Models;

public class ProjectUserRelations
{
    /// <summary>
    /// A list of userIds and roles to add to the project.
    /// </summary>
    public required List<ProjectUserRelationItem> Relations { get; init; }
}