using Library.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Conf.Options
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);

            builder.Ignore(bt => bt.Id);

            builder.HasKey(bt => new { bt.BookId, bt.TagId });

            builder.HasOne(bt => bt.Book)
                   .WithMany(b => b.BookTags)
                   .HasForeignKey(bt => bt.BookId);

            builder.HasOne(bt => bt.Tag)
                   .WithMany(t => t.BookTags)
                   .HasForeignKey(bt => bt.TagId);
        }
    }
}
