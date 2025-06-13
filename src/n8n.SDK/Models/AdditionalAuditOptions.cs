namespace n8n.SDK.Models;

public class AdditionalAuditOptions
{
    /// <summary>
    /// Days for a workflow to be considered abandoned if not executed
    /// </summary>
    public int? DaysAbandonedWorkflow { get; set; }

    /// <summary>
    /// Categories to include in audit. Possible values: credentials, database, nodes, filesystem, instance
    /// </summary>
    public List<string>? Categories { get; set; }
}