using daily_log_api.Services;

namespace daily_log_api.IServices
{
    public interface IAuthService
    {
        public TokenModel? Auth(string email, string senha);

    }
}
