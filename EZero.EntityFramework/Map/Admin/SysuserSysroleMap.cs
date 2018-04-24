using EZero.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EZero.Domain.Model.Admin;

namespace EZero.EntityFrameworkCore.Map.Admin
{
    public class SysuserSysroleMap : EntityTypeConfiguration<SysuserSysrole>
    {
        public override void Map(EntityTypeBuilder<SysuserSysrole> builder)
        {
            builder.HasKey(t => new { t.SysuserId, t.SysroleId});

            builder.HasOne(t => t.Sysuser).WithMany(t => t.SysuserSysroles).HasForeignKey(t => t.SysuserId);

            builder.HasOne(t => t.Sysrole).WithMany(t => t.SysuserSysroles).HasForeignKey(t => t.SysroleId);
        }

    }
}
