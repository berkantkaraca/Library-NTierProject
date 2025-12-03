using AutoMapper;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Models;

namespace Library.Bll.Managers.Concretes
{
    public class BookTagManager(IBookTagRepository repository, IMapper mapper) : BaseManager<BookTagDto, BookTag>(repository, mapper), IBookTagManager
    {
        private readonly IBookTagRepository _repository = repository;
    }
}
