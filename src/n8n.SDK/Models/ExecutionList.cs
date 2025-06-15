namespace n8n.SDK.Models;

public class ExecutionList
{
    public required List<Execution> Data { get; init; }

    /// <summary>
    /// Paginate through executions by setting the cursor parameter to a nextCursor attribute returned by a previous request. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? NextCursor { get; set; }
}