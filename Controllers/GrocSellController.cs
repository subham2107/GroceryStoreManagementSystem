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
    public class GrocSellController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        //public GrocSellController()
        //{
        //    _log4net = log4net.LogManager.GetLogger(typeof(GrocSellController));
        //}
        private readonly GrocContext _context;
        public GrocSellController(GrocContext context)
        {
            _context = context;
            _log4net = log4net.LogManager.GetLogger(typeof(GrocSellController));
        }
        // GET: api/<GrocSellController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GrocSellController>/5
        [HttpGet("{id}")]
        public IEnumerable<grocsell> Get(int id)
        {
            IEnumerable<grocsell> grocsells = _context.grocsells.ToList();
            grocsells = from x in grocsells where x.GrocId == id select x;
            return grocsells;
        }

        // POST api/<GrocSellController>
        [HttpPost]
     
        public string Post([FromBody] grocsell obj)
        {
            _context.grocsells.Add(obj);
            _context.SaveChanges();
            return "Congrats!Successfully added";
        }
        // PUT api/<GrocSellController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GrocSellController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
