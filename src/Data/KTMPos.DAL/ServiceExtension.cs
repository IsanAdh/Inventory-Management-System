using KTMPos.DAL.Data;
using KTMPos.DAL.Repository.CategoryRepository;
using KTMPos.DAL.Repository.LoginRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KTMPos.DAL
{
    public static class ServiceExtension
    {
        public static void AddDataAccessLayer(this IServiceCollection service,string connectionString)
        {
            service.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(connectionString));
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<ILoginRepository, LoginRepository>();
        }
    }
}
