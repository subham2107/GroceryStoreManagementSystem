using GroceryStoreMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Repository
{
    public interface IGrocSell
    {
        public IEnumerable<grocsell> Get();

        public IQueryable<grocsell> Get(int id);
        public string Post(grocsell obj);


    }
}
