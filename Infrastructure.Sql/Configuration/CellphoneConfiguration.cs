using Domain.Entittes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Sql.Configuration
{
    public class CellphoneConfiguration : IEntityTypeConfiguration<Cellphone>
    {
        public void Configure(EntityTypeBuilder<Cellphone> builder)
        {
            builder.Property(a => a.CellphoneName).HasColumnType("varchar(50)");
            builder.Property(a => a.CellphoneDescription).HasColumnType("varchar(500)");
        }
    }
}
