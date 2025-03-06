namespace KTMPos.DAL.Repository.LoginRepository
{
    public interface ILoginRepository
    {
        Task<int> LoginAsync(string username, string password);
    }
}
