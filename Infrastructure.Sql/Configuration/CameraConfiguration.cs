using Domain.Entittes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Sql.Configuration
{
    public class CameraConfiguration : IEntityTypeConfiguration<Camera>
    {
        public void Configure(EntityTypeBuilder<Camera> builder)
        {
            builder.Property(a => a.CameraName).HasColumnType("varchar(50)");
            builder.Property(a => a.CameraDescription).HasColumnType("varchar(500)");
        }
    }
}
