using KTMPos.BAL.Services.CategoryServices;
using KTMPos.DAL.Repository.CategoryRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.BAL
{
    public static  class ServiceExtension
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
