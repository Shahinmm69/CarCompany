using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class CostHistory : BaseEntity
    {
        public CustomDate customdate { get; set; }
        public int Cost { get; set; }
        public int ModelId { get; set; }

        public virtual CarModel Model { get; set; } = null!;
    }
    public class DateConfiguration : IEntityTypeConfiguration<CostHistory>
    {
        public void CostHistoryConfigure(EntityTypeBuilder<CostHistory> builder)
        {
            builder.Property(p => p.customdate).IsRequired();
            builder.Property(p => p.Cost).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.CostHistories).HasForeignKey(p => p.ModelId);
        }
    }
}
