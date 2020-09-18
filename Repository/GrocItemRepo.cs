using GroceryStoreMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Repository
{
    public class GrocItemRepo:IGrocItem
    {
        private readonly GrocContext _context;
        public GrocItemRepo(GrocContext context)
        {
            _context = context;
          
        }

        public IEnumerable<grocitem> Get()
        {
            return _context.grocitems.ToList();
        }

        public IQueryable<grocitem> Get(int id)
        {

           IQueryable<grocitem> obj = _context.grocitems.Where(g=>g.GrocId==id);
           
                return obj;
        }

        
        public string Post(grocitem obj)
        {
          
            _context.grocitems.Add(obj);
            _context.SaveChanges();
            return "Congrats!Successfully added";
        }

       
        public string Put(int id, grocitem value)
        {

            IQueryable<grocitem> obj = _context.grocitems.Where(g => g.GrocId == id);
            if (obj.Count()>0)
             
            {
                grocitem obj1 = obj.FirstOrDefault();
                obj1.GrocName = value.GrocName;
                obj1.GrocPrice = value.GrocPrice;
                obj1.GrocQuantity = value.GrocQuantity;
                obj1.GrocTime = value.GrocTime;
                _context.SaveChanges();
                return "Congrats!Updated successfully";
            }
            else
            {
                return "Enter a Id which already exists!";
            }
        }

      

            public string Delete(int id)
            {
                IQueryable<grocitem> obj = _context.grocitems.Where(g => g.GrocId == id);
                if (obj.Count() > 0)
                {
                    IQueryable<grocsell> obj2 = _context.grocsells.Where(x => x.GrocId == id);
                    foreach (var item in obj2)
                    {
                        _context.grocsells.Remove(item);
                    }
                    _context.grocitems.Remove(obj.FirstOrDefault());
                    _context.SaveChanges();
                    return "Successfully Deleted";
                }

                return "GrocId does not exist ";

            }
        

    }
}
