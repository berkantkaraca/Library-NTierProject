using Library.Dal.Repositories.Abstracts;
using Library.Dal.ContextClasses;
using Library.Entities.Models;

namespace Library.Dal.Repositories.EfConcretes
{
    public class CategoryRepository(MyContext context) : BaseRepository<Category>(context), ICategoryRepository
    {

    }
}
