using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EZero.Domain.Model.Admin;

namespace EZero.EntityFrameworkCore.Map.Admin
{
    public class SysuserMap : EntityTypeConfiguration<Sysuser>
    {
        public override void Map(EntityTypeBuilder<Sysuser> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.LoginName).IsRequired().HasMaxLength(16);
            builder.Property(t => t.UserName).HasMaxLength(16);
            builder.Property(t => t.PasswordHash).IsRequired().HasMaxLength(256);
            builder.Property(t => t.Salt).IsRequired().HasMaxLength(256);

        }

    }
}
