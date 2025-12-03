using Library.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Conf.Options
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
        }
    }
}
