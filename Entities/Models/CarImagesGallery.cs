using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class CarImagesGallery: BaseEntity
    {
        public string CarImagesGalleryAddress { get; set; }
        public int ModelId { get; set; }

        public virtual CarModel Model { get; set; } = null!;
    }
    public class ImageConfiguration : IEntityTypeConfiguration<CarImagesGallery>
    {
        public void CarImageConfigure(EntityTypeBuilder<CarImagesGallery> builder)
        {
            builder.Property(p => p.CarImagesGalleryAddress).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.CarImagesGalleries).HasForeignKey(p => p.ModelId);
        }
    }
}
