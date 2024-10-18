using System;
using System.Collections.Generic;

namespace daily_log_api.Models;

public partial class Log
{
    public int? Id { get; set; }

    public string? Title { get; set; } = null!;

    public string? Text { get; set; } = null!;

    public int? TemplateId { get; set; }

    public int? LogEntriesId { get; set; }

    public TimeOnly? BeginTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual LogEntry? LogEntries { get; set; } = null!;

    public virtual Template? Template { get; set; }
}
