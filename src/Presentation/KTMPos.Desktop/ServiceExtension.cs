using KTMPos.Desktop.Forms;
using KTMPos.Desktop.Forms.ChildForms.InventoryModule;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KTMPos.Desktop
{
    public static class ServiceExtension
    {
        //IConfiguration pani presentation layer mai raakhna paryo
        public static void AddPresentationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<LoginForm>();
            services.AddSingleton<KtmPOS>();
            services.AddTransient<CategoryForm>();
            services.AddSingleton(configuration);
        }
    }
}
