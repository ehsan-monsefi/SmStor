using Domain.Entittes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Sql.Configuration
{
    public class LaptopConfiguration : IEntityTypeConfiguration<Laptop>
    {
        public void Configure(EntityTypeBuilder<Laptop> builder)
        {
            builder.Property(a => a.LaptopName).HasColumnType("varchar(50)");
            builder.Property(a => a.LaptopDescription).HasColumnType("varchar(500)");
        }
    }
}
