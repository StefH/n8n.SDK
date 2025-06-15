namespace n8n.SDK.Models;

public class CreateUserRequest
{
    public required string Email { get; init; }

    public string? Role { get; init; }
}