using GroceryStoreMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Repository
{
    public class GrocSellRepo:IGrocSell
    {
        private readonly GrocContext _context;
        public GrocSellRepo(GrocContext context)
        {
            _context = context;
         
        }
        public IEnumerable<grocsell> Get()
        {
            return _context.grocsells.ToList();
        }

        public IQueryable<grocsell> Get(int id)
        {
            IQueryable<grocsell> obj = _context.grocsells.Where(g => g.SellId == id);

            return obj;
        }
        

        public string Post(grocsell obj)
        {
           
            var ob = _context.grocitems.Where(x => x.GrocId == obj.GrocId).FirstOrDefault();
            if (ob != null)
            {
                _context.grocsells.Add(obj);
                _context.SaveChanges();
                return "Congrats!Successfully added";
            }
            else
            {
                return "Sorry,the grocery item is not present in main table";
            }
        }
    }
}
