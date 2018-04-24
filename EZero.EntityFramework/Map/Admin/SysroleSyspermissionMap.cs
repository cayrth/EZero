using EZero.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EZero.Domain.Model.Admin;

namespace EZero.EntityFrameworkCore.Map.Admin
{
    public class SysroleSyspermissionMap : EntityTypeConfiguration<SysroleSyspermission>
    {
        public override void Map(EntityTypeBuilder<SysroleSyspermission> builder)
        {
            builder.HasKey(t => new { t.SysroleId, t.SyspermissionId});

            builder.HasOne(t => t.Sysrole).WithMany(t => t.SysroleSyspermissions).HasForeignKey(t => t.SysroleId);
            builder.HasOne(t => t.Syspermission).WithMany(t => t.SysroleSyspermissions).HasForeignKey(t => t.SyspermissionId);
        }

    }
}
