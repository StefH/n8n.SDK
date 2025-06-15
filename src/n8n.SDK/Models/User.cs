namespace n8n.SDK.Models;

public class User
{
    public string? Id { get; set; }

    /// <summary>
    /// User email.
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// User's first name
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// User's last name
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Whether the user finished setting up their account in response to the invitation (true) or not (false).
    /// </summary>
    public bool? IsPending { get; set; }

    /// <summary>
    /// Time the user was created.
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Last time the user was updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public string? Role { get; set; }
}