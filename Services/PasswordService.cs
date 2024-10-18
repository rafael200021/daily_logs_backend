namespace daily_log_api.Services
{
    public class PasswordService
    {

        public static string HashSenha(string senha)
        {
            return  BCrypt.Net.BCrypt.HashPassword(senha, 12);


        }

        public static bool VerificarSenha(string senha, string hash)
        {

              return BCrypt.Net.BCrypt.Verify(senha, hash);

        }

    }
}
