using Library.WebApi.MappingProfiles;

namespace Library.WebApi.MapperResolvers
{
    public static class VmMapperResolver
    {
        public static void AddVmMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(VmMappingProfile));
        }
    }
}
