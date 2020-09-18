using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreMgmt.Models;
using GroceryStoreMgmt.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryStoreMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrocItemController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        private readonly GrocItemRepo _context;
       

        public GrocItemController(GrocItemRepo obj)
        {
            _context = obj;
            _log4net = log4net.LogManager.GetLogger(typeof(GrocItemController));
        }
        


        // GET: api/<GrocItemController>
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_context.Get());
        }

        // GET api/<GrocItemController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            IQueryable<grocitem> obj = _context.Get(id);
            if (obj.Count()>0)
            return Ok(obj.FirstOrDefault());
            return BadRequest(obj);
        }
       
        // POST api/<GrocItemController>
        [HttpPost]
        public string Post([FromBody] grocitem obj)
        {
            _log4net.Info(" Http POST Request done");
            
            return _context.Post(obj);
        }

        // PUT api/<GrocItemController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] grocitem value)
        {
            
                return _context.Put(id,value);
            
        }

        

        // DELETE api/<GrocItemController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return (_context.Delete(id));
        }
    }
}
