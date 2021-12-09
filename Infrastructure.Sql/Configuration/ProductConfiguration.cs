using Domain.Entittes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Sql.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(a => a.Name).HasColumnType("varchar(50)");
            builder.Property(a => a.Description).HasMaxLength(500).IsRequired();
        }
    }
}
