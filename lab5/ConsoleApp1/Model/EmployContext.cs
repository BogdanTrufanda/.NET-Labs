using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1.Model
{
    public class EmployContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployContext()
        : base("name=EmployContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmploy>(m => m.Requires("EmployeeType")
            .HasValue(1))
            .Map<HourEmploy>(m => m.Requires("EmployeeType")
            .HasValue(2));
        }

    }
}
