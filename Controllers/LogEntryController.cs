using System.ComponentModel;
using daily_log_api.IRepositories;
using daily_log_api.IServices;
using daily_log_api.Models;
using Microsoft.AspNetCore.Authorization;

namespace daily_log_api.Controllers
{
    [Authorize]

    public class LogEntryController : DefaultController<LogEntry>
    {
        public LogEntryController(IDefaultService<LogEntry> repository) : base(repository) { }
    }
}