using System;
using System.Collections.Generic;

namespace daily_log_api.Models;

public partial class Template
{
    public int? Id { get; set; }

    public string? Text { get; set; }

    public string? Name { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual User? User { get; set; }
}
