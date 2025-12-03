namespace Library.Validators.RequestModels.Books
{
    public class CreateBookRequestModel
    {
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
    }
}
