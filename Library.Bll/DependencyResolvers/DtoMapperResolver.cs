using Library.Bll.MappingProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Bll.DependencyResolvers
{
    public static class DtoMapperResolver
    {
        public static void AddDtoMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DtoMappingProfile));
        }
    }
}
