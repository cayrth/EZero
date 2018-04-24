using EZero.Domain.Model;
using EZero.Domain.Model.Admin;
using EZero.EntityFrameworkCore.Map;
using EZero.EntityFrameworkCore.Map.Admin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.EntityFrameworkCore
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        #region Admin

        public DbSet<Sysrole> Sysrole { get; set; }
        public DbSet<Syspermission> Syspermission { get; set; }
        public DbSet<SysuserSysrole> SysuserSysrole { get; set; }
        public DbSet<SysroleSyspermission> SysroleSyspermission { get; set; }

        #endregion


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new UserMap());

            // Admin
            modelBuilder.AddConfiguration(new SysuserMap());
            modelBuilder.AddConfiguration(new SysroleMap());
            modelBuilder.AddConfiguration(new SyspermissionMap());
            modelBuilder.AddConfiguration(new SysuserSysroleMap());
            modelBuilder.AddConfiguration(new SysroleSyspermissionMap());

        }
    }
}
