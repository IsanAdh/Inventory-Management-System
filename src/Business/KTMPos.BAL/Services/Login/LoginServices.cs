
using KTMPos.DAL.Repository.LoginRepository;

namespace KTMPos.BAL.Services.Login
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServices(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<int> LoginAsync(string username, string password)
        {
            int userId= await _loginRepository.LoginAsync(username, password);
            return userId;  
        }
    }
}
