namespace n8n.SDK.Models;

public class Audit
{
    public object? CredentialsRiskReport { get; set; }

    public object? DatabaseRiskReport { get; set; }

    public object? FilesystemRiskReport { get; set; }

    public object? NodesRiskReport { get; set; }

    public object? InstanceRiskReport { get; set; }
}