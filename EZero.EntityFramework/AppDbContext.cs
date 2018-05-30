using EZero.Domain.Model;
using EZero.Domain.Model.Admin;
using EZero.EntityFrameworkCore.Map;
using EZero.EntityFrameworkCore.Map.Admin;
using EZero.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EZero.EntityFrameworkCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        //public override int SaveChanges()
        //{
        //    try
        //    {
        //        var result = base.SaveChanges();
        //        return result;
        //    }
        //    catch (BaseException ex)
        //    {
        //        return 0;
        //    }
        //}

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    try
        //    {
        //        var result = base.SaveChangesAsync(cancellationToken);
        //        return result;
        //    }
        //    catch (BaseException ex)
        //    {
        //        throw;
        //    }
        //}


        public DbSet<User> Users { get; set; }

        #region Admin

        public DbSet<Sysrole> Sysrole { get; set; }
        public DbSet<Syspermission> Syspermission { get; set; }
        public DbSet<SysuserSysrole> SysuserSysrole { get; set; }
        public DbSet<SysroleSyspermission> SysroleSyspermission { get; set; }

        #endregion


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
