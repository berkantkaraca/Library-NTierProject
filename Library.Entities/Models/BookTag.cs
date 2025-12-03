namespace Library.Entities.Models
{
    public class BookTag : BaseEntity
    {
        public int TagId { get; set; }
        public int BookId { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Book Book { get; set; }
    }
}
