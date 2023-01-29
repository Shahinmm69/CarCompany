using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Image;

namespace Entities
{
    public class Image: BaseEntity
    {
        public BitMap CarImage { get; set; }
        public int ModelId { get; set; }

        public virtual Model Model { get; set; } = null!;
    }
    public class PostConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(p => p.CarImage).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.Images).HasForeignKey(p => p.ModelId);
        }
    }
}
