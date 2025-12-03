using Project.Entities.Enum;

namespace Library.Validators.ResponseModels.BookTags
{
    public class BookTagResponseModel
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int BookId { get; set; }
        public DataStatus Status { get; set; }
    }
}
