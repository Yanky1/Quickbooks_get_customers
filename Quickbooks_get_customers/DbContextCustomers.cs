using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Quickbooks_get_customers
{
    public class DbContextCustomers : DbContext
    {
      

        public DbSet<CustNameModel> QBcust { get; set; }
    }
}
