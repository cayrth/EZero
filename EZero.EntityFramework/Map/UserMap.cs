using EZero.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EZero.EntityFrameworkCore.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Mobile).HasMaxLength(16);
            builder.Property(t => t.Realname).HasMaxLength(16);
            builder.Property(t => t.Email).HasMaxLength(64);
        }
    }
}
