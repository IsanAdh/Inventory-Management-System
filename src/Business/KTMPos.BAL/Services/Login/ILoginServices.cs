using KTMPos.Common.Dto;
using KTMPos.Common.Dto.Logins;

namespace KTMPos.BAL.Services.Login
{
    public interface ILoginServices
    {
        Task<DataOutputDto<LoginReadDto>> LoginAsync(string username,string password);
    }
}
