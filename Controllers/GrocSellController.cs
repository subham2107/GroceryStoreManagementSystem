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
    public class GrocSellController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        private readonly GrocSellRepo _context;
        public GrocSellController(GrocSellRepo context)
        {
            _context = context;
            _log4net = log4net.LogManager.GetLogger(typeof(GrocSellController));
        }
        // GET: api/<GrocSellController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Get());
        }

        // GET api/<GrocSellController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IQueryable<grocsell> obj = _context.Get(id);
            if (obj.Count() > 0)
                return Ok(obj);
            return BadRequest(obj);
        }

        // POST api/<GrocSellController>
        [HttpPost]
     
        public string Post([FromBody] grocsell obj)
        {
            
            return _context.Post(obj);
        }
       

        
    }
}
