using CRUDNewWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNewWinForm.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
    }
}
