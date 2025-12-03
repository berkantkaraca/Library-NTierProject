using Library.Entities.Enums;

namespace Library.Validators.ResponseModels.Books
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
        public DataStatus Status { get; set; }
    }
}
