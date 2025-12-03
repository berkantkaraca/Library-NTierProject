namespace Library.Entities.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<BookTag> BookTags { get; set; }
    }
}
