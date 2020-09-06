using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Models
{
    public class GrocContext : DbContext
    {
        public GrocContext()
        {

        }
        public GrocContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<grocsell> grocsells { get; set; }
        public virtual DbSet<grocitem> grocitems {get;set;}
    }
}
