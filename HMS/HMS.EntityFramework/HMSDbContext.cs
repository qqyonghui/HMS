
using HMS.Common.Ioc;
using Microsoft.EntityFrameworkCore;
using System;

namespace HMS.EntityFramework
{
    public class HMSDbContext: DbContext, IDependency
    {
        public HMSDbContext(DbContextOptions<HMSDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<SysUser> SysUser { get; set; }

        public DbSet<Permissions> Permissions { get; set; }

        public DbSet<SysRoles> SysRoles { get; set; }

        public DbSet<SysCatagory> SysCatagories { get; set; }

        public DbSet<Tenants> Tenants { get; set; }

    }
}
