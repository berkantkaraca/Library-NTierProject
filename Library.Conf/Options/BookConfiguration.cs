using Library.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Conf.Options
{
    public class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder.HasOne(b => b.Category)
                   .WithMany(c => c.Books)
                   .HasForeignKey(b => b.CategoryId);
        }
    }
}
