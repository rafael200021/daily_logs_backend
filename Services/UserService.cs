using daily_log_api.IRepositories;
using daily_log_api.IServices;
using daily_log_api.Models;

namespace daily_log_api.Services
{
    public class UserService : DefaultService<User>, IUserService
    {


        public UserService(IUserRepository repository) : base(repository)
        {
        }

    }
}
