using daily_log_api.Models;

namespace daily_log_api.IRepositories
{
    public interface IUserRepository:IDefaultRepository<User>
    {

        public User GetByEmail(string email);


    }
}
