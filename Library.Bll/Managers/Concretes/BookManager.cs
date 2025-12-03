using AutoMapper;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Models;

namespace Library.Bll.Managers.Concretes
{
    public class BookManager(IBookRepository repository, IMapper mapper) : BaseManager<BookDto, Book>(repository, mapper), IBookManager
    {
        private readonly IBookRepository _repository = repository;
    }
}
