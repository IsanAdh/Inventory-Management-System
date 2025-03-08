
using KTMPos.Common.Dto.Logins;
using KTMPos.Common.Dto;
using KTMPos.DAL.Repository.LoginRepository;
using KTMPos.Common.Utilities;
using KTMPos.Common.Enums;
using KTMPos.Common.Constants;

namespace KTMPos.BAL.Services.Login
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServices(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<DataOutputDto<LoginReadDto>> LoginAsync(string username, string password)
        {
            try
            {
                var userId = await _loginRepository.LoginAsync(username, password);
                var logins = new List<LoginReadDto>
            {
                new LoginReadDto
                {
                    Id=userId,
                }
            };
                return OutputDtoConverter.SetDataOutputDto(Status.Success, "Login Sucessful", logins);
            }
            catch (Exception ex)
            {

                return OutputDtoConverter.SetDataOutputDto(Status.Success, Message.Success, new List<LoginReadDto>(), new List<string> { ex.Message });

            }

        }
    }
}
