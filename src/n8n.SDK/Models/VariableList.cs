namespace n8n.SDK.Models;

public class VariableList
{
    public required List<Variable> Data { get; init; }

    /// <summary>
    /// Paginate through variables by setting the cursor parameter to a nextCursor attribute returned by a previous request. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? NextCursor { get; set; }
}