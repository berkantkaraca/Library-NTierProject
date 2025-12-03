using Library.Dal.Repositories.Abstracts;
using Library.Dal.ContextClasses;
using Library.Entities.Models;

namespace Library.Dal.Repositories.EfConcretes
{
    public class BookRepository(MyContext context) : BaseRepository<Book>(context), IBookRepository
    {

    }
}
