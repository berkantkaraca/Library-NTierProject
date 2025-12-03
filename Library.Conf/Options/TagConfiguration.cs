using Library.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Conf.Options
{
    public class TagConfiguration : BaseConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);
        }
    }
}
