using AutoMapper;
using Library.Bll.Dtos;
using Library.Validators.RequestModels.Categories;
using Library.Validators.ResponseModels.Categories;
using Library.Validators.RequestModels.Authors;
using Library.Validators.ResponseModels.Authors;
using Library.Validators.RequestModels.Books;
using Library.Validators.ResponseModels.Books;
using Library.Validators.RequestModels.Tags;
using Library.Validators.ResponseModels.Tags;
using Library.Validators.RequestModels.BookTags;
using Library.Validators.ResponseModels.BookTags;

namespace Library.WebApi.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateCategoryRequestModel, CategoryDto>();
            CreateMap<UpdateCategoryRequestModel, CategoryDto>();
            CreateMap<CategoryDto, CategoryResponseModel>();

            CreateMap<CreateAuthorRequestModel, AuthorDto>();
            CreateMap<UpdateAuthorRequestModel, AuthorDto>();
            CreateMap<AuthorDto, AuthorResponseModel>();

            CreateMap<CreateBookRequestModel, BookDto>();
            CreateMap<UpdateBookRequestModel, BookDto>();
            CreateMap<BookDto, BookResponseModel>();

            CreateMap<CreateTagRequestModel, TagDto>();
            CreateMap<UpdateTagRequestModel, TagDto>();
            CreateMap<TagDto, TagResponseModel>();

            CreateMap<CreateBookTagRequestModel, BookTagDto>();
            CreateMap<UpdateBookTagRequestModel, BookTagDto>();
            CreateMap<BookTagDto, BookTagResponseModel>();
        }
    }
}
