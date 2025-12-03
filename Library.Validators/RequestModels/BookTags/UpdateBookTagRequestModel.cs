namespace Library.Validators.RequestModels.BookTags
{
    public class UpdateBookTagRequestModel
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int BookId { get; set; }
    }
}
