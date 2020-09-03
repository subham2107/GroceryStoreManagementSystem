using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreMgmt.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryStoreMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrocItemController : ControllerBase
    {
        //readonly log4net.ILog _log4net;
        //public GrocItemController()
        //{
        //    _log4net = log4net.LogManager.GetLogger(typeof(GrocItemController));
        //}


        private readonly GrocContext _context;
        public GrocItemController(GrocContext context)
        {
            _context = context;
        }

       
        // GET: api/<GrocItemController>
        [HttpGet]
        public IEnumerable<grocitem> Get() //<grocitem> grocitems
        {
            return _context.grocitems.ToList();
        }

        // GET api/<GrocItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
       
        // POST api/<GrocItemController>
        [HttpPost]
        public string Post([FromBody] grocitem obj)
        {
            _context.grocitems.Add(obj);
            _context.SaveChanges();
            return "Congrats!Successfully added";
        }

        // PUT api/<GrocItemController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] grocitem value)
        {
            grocitem obj = _context.grocitems.Find(id);
            obj.GrocName = value.GrocName;
            obj.GrocPrice = value.GrocPrice;
            obj.GrocQuantity = value.GrocQuantity;
            obj.GrocTime = value.GrocTime;
            _context.SaveChanges();
            return "Congrats!Updated successfully";
        }

        // DELETE api/<GrocItemController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            grocitem obj = _context.grocitems.Find(id);
            _context.grocitems.Remove(obj);
            _context.SaveChanges();
            return "Congrats!Deleted successfully";
        }
    }
}
