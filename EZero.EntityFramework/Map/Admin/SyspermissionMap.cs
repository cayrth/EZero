using EZero.Domain.Model.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.EntityFrameworkCore.Map.Admin
{
    public class SyspermissionMap : EntityTypeConfiguration<Syspermission>
    {
        public override void Map(EntityTypeBuilder<Syspermission> builder)
        {

            builder.HasKey(t => t.Id);
            builder.OwnsOne(t => t.SyspermissionRoute, cb => 
            {
                cb.Property(x => x.Area).HasColumnName("Area").HasMaxLength(32);
                cb.Property(x => x.Controller).HasColumnName("Controller").HasMaxLength(32);
                cb.Property(x => x.Action).HasColumnName("Action").HasMaxLength(32);
            });
            builder.Property(t => t.SyspermissionName).IsRequired().HasMaxLength(64);
            builder.Property(t => t.SyspermissionTitle).IsRequired().HasMaxLength(32);
            //builder.Property(t => t.SyspermissionRoute.Area).HasColumnName("Area").HasMaxLength(32);
            //builder.Property(t => t.SyspermissionRoute.Controller).IsRequired().HasColumnName("Controller").HasMaxLength(32);
            //builder.Property(t => t.SyspermissionRoute.Action).IsRequired().HasColumnName("Action").HasMaxLength(32);
            builder.Property(t => t.Icon).HasMaxLength(32);
            builder.Property(t => t.IsNavigation).IsRequired();

            builder.Property(t => t.SerialNumber).IsRequired();

            builder.HasIndex(t => t.SyspermissionName).IsUnique();

            builder.HasMany(t => t.Children).WithOne(t => t.Parent).HasForeignKey(t => t.Pid);
        }
    }
}
