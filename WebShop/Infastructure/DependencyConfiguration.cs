using Microsoft.Extensions.DependencyInjection;
using WebShop.BL.Interfaces;
using WebShop.BL.Services;
using WebShop.DAL;
using WebShop.DAL.Interfaces;
using WebShop.DAL.Models;
using WebShop.DAL.Repositories;

namespace WebShop.PL.Infastructure
{
    public static class DependencyConfiguration
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            //DAL configuration
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IGenericRepository<CategoryEntity>, GenericRepository<CategoryEntity>>();

            //BL configuration
            service.AddTransient<ICategoryService,CategoryService >();
        }
    }
}
