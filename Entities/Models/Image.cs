using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class Image: BaseEntity
    {
        public string CarImageAddress { get; set; }
        public int ModelId { get; set; }

        public virtual Model Model { get; set; } = null!;
    }
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(p => p.CarImageAddress).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.Images).HasForeignKey(p => p.ModelId);
        }
    }
}
