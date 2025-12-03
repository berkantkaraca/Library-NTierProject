using Library.Bll.DependencyResolvers;
using FluentValidation.AspNetCore;
using FluentValidation;
using Library.WebApi.MapperResolvers;
using Library.Validators.Validators.Categories;

namespace Library.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateCategoryRequestModelValidator>();

            builder.Services.AddDbContextServices();
            builder.Services.AddRepositoryServices();
            builder.Services.AddManagerServices();
            builder.Services.AddDtoMapperService();
            builder.Services.AddVmMapperService();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
