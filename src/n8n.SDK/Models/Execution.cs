﻿namespace n8n.SDK.Models;

public class Execution
{
    public required string Id { get; set; }

    public object? Data { get; set; }

    public bool Finished { get; set; }

    public string? Mode { get; set; }

    public long? RetryOf { get; set; }

    public long? RetrySuccessId { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? StoppedAt { get; set; }

    public required string WorkflowId { get; set; }

    public DateTime? WaitTill { get; set; }

    public object? CustomData { get; set; }
}