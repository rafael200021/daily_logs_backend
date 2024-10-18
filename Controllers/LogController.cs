using daily_log_api.IServices;
using daily_log_api.Models;
using Microsoft.AspNetCore.Authorization;

namespace daily_log_api.Controllers
{

    [Authorize]
    public class LogController : DefaultController<Log>
    {

        public LogController(IDefaultService<Log> service) : base(service) { }

    }
}