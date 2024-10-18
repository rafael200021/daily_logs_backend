using System;
using System.Collections.Generic;

namespace daily_log_api.Models;

public partial class LogEntry
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime Date { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual User? User { get; set; } = null!;
}
