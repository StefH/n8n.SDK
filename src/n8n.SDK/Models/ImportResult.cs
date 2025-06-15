namespace n8n.SDK.Models;

public class ImportResult
{
    public ImportVariables? Variables { get; set; }

    public List<ImportCredential>? Credentials { get; set; }

    public List<ImportWorkflow>? Workflows { get; set; }

    public ImportTagGroup? Tags { get; set; }
}