using System;
using System.Collections.Generic;

namespace daily_log_api.Models;

public partial class User
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<LogEntry> LogEntries { get; set; } = new List<LogEntry>();

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();
}
