using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApi.Entities;

namespace RestApi.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Sector>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(m => !m.IsDeleted);



        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
