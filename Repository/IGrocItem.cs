using GroceryStoreMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Repository
{
    public interface IGrocItem
    {
        public IEnumerable<grocitem> Get();
        public IQueryable<grocitem> Get(int id);
        public string Post( grocitem obj);
        public string Put(int id,grocitem value);
        public string Delete(int id);
    }
}
