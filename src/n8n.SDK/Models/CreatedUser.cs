namespace n8n.SDK.Models;

public class CreatedUser
{
    public string? Id { get; set; }

    public string? Email { get; set; }

    public string? InviteAcceptUrl { get; set; }

    public bool? EmailSent { get; set; }
}