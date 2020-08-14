using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Config
{
    public class SomeDataConfig : IEntityTypeConfiguration<SomeData>
    {
        public void Configure(EntityTypeBuilder<SomeData> builder)
        {
            builder.ToTable("SomeData");

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Code)
                .HasColumnName("code")
                .HasMaxLength(3)
                .IsRequired();

        }
    }
}
