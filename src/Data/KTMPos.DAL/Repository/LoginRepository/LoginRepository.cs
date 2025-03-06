
using KTMPos.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace KTMPos.DAL.Repository.LoginRepository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext _context;
        public LoginRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> LoginAsync(string username, string password)
        {
            int userId =  await _context
                              .Logins
                              .Where(x => x.UserName == username && x.Password == password)
                              .Select(x => x.Id)
                              .FirstOrDefaultAsync();
            return userId;
        }
    }
}
