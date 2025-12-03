using Library.Dal.Repositories.Abstracts;
using Library.Dal.ContextClasses;
using Library.Entities.Models;

namespace Library.Dal.Repositories.EfConcretes
{
    public class TagRepository(MyContext context) : BaseRepository<Tag>(context), ITagRepository
    {

    }
}
