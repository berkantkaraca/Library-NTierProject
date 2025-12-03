using AutoMapper;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Models;

namespace Library.Bll.Managers.Concretes
{
    public class AuthorManager(IAuthorRepository repository, IMapper mapper) : BaseManager<AuthorDto, Author>(repository, mapper), IAuthorManager
    {
        private readonly IAuthorRepository _repository = repository;
    }
}
