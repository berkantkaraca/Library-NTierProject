namespace Library.Bll.Dtos
{
    public class BookDto : BaseDto
    {
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
    }
}
