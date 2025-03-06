namespace KTMPos.BAL.Services.Login
{
    public interface ILoginServices
    {
        Task<int> LoginAsync(string username,string password);
    }
}
