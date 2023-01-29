using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Model: BaseEntity
    {
        public string ModelName { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Date> Dates { get; set; }
    }
    public class PostConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(p => p.ModelName).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.Car).WithMany(c => c.Models).HasForeignKey(p => p.CarId);
        }
    }
}
