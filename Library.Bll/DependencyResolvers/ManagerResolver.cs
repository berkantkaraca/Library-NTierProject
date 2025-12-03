using Library.Bll.Managers.Abstracts;
using Library.Bll.Managers.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Bll.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<IBookTagManager, BookTagManager>();
            services.AddScoped<ITagManager, TagManager>();
        }
    }
}
