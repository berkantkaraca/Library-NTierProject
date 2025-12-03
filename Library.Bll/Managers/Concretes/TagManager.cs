using AutoMapper;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Models;

namespace Library.Bll.Managers.Concretes
{
    public class TagManager(ITagRepository repository, IMapper mapper) : BaseManager<TagDto, Tag>(repository, mapper), ITagManager
    {
        private readonly ITagRepository _repository = repository;
    }
}
