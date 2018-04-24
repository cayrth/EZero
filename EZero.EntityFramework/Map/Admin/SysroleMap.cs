using EZero.Domain.Model.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.EntityFrameworkCore.Map.Admin
{
    public class SysroleMap : EntityTypeConfiguration<Sysrole>
    {
        public override void Map(EntityTypeBuilder<Sysrole> builder)
        {

            builder.HasKey(t => t.Id);

            builder.Property(t => t.SysroleName).IsRequired().HasMaxLength(32);
            builder.Property(t => t.SerialNumber).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(64);
        }
    }
}
