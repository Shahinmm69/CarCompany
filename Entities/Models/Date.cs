﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Date: BaseEntity
    {
		public CustomDate customdate { get; set; }
		public int Cost { get; set; }
        public int ModelId { get; set; }
        
        public virtual Model Model { get; set; } = null!;
    }
    public class PostConfiguration : IEntityTypeConfiguration<Date>
    {
        public void Configure(EntityTypeBuilder<Date> builder)
        {
            builder.Property(p => p.DateCost).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.Dates).HasForeignKey(p => p.ModelId);
        }
    }
}