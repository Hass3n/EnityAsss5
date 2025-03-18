using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFwAsss4.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnityAsss5.Context
{
    internal class ComapnySuDatabase : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanySuDatabaseSQl; Trusted_connection=true;Encrypt=false");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>()
                .HasOne(E => E.Department)
                .WithOne(D => D.Manger)
                .HasForeignKey<Department>(D => D.MangerId)
                 .OnDelete(DeleteBehavior.NoAction);

                
                
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Department> departments { get; set; }

        public DbSet<Employee> Employees { get; set; }




    }
}
