using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class CommContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public CommContext()
        : base("name=CommContext")
        {
        }
    }
}
