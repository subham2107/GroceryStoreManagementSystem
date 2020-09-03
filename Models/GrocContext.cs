using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Models
{
    public class GrocContext : DbContext
    {
        public GrocContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<grocsell> grocsells { get; set; }
        public DbSet<grocitem> grocitems {get;set;}
    }
}
