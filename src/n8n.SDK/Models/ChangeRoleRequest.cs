namespace n8n.SDK.Models;

public class ChangeRoleRequest
{
    /// <summary>
    /// New role for the user
    /// </summary>
    public required string NewRoleName { get; init; }
}