using AutoMapper;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Models;

namespace Library.Bll.Managers.Concretes
{
    public class CategoryManager(ICategoryRepository repository, IMapper mapper) : BaseManager<CategoryDto, Category>(repository, mapper), ICategoryManager
    {
        private readonly ICategoryRepository _repository = repository;
    }
}