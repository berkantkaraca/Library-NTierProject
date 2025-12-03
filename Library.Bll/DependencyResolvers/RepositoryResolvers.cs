using Library.Dal.Repositories.Abstracts;
using Library.Dal.Repositories.EfConcretes;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Bll.DependencyResolvers
{
    public static class RepositoryResolvers
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookTagRepository, BookTagRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
        }
    }
}
