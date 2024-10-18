using daily_log_api.IRepositories;
using daily_log_api.IServices;
using daily_log_api.Models;
using daily_log_api.Repositories;

namespace daily_log_api.Services
{
    public class TokenModel
    {
        public string Token { get; set; }
    }

    public class AuthService:IAuthService
    {

        public readonly IUserRepository _repository;

        public AuthService(IUserRepository repository)
        {
            _repository = repository;

        }

        public TokenModel? Auth(string email,string senha)
        {
            User? user = _repository.GetByEmail(email);

            if(user == null) { return null;  }

            if(PasswordService.VerificarSenha(senha,user.Password) == false) { return null; }

            string token = JWTService.GerarToken(user); 

            return new TokenModel { Token = token };

        }

    }
}
