namespace n8n.SDK.Models;

public class WorkflowSettings
{
    public bool? SaveExecutionProgress { get; set; }

    public bool? SaveManualExecutions { get; set; }

    public string? SaveDataErrorExecution { get; set; }

    public string? SaveDataSuccessExecution { get; set; }

    public decimal? ExecutionTimeout { get; set; }

    /// <summary>
    /// The ID of the workflow that contains the error trigger node.
    /// </summary>
    public string? ErrorWorkflow { get; set; }

    public string? Timezone { get; set; }

    public string? ExecutionOrder { get; set; }
}