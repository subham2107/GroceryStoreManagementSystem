using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Models
{
    public class grocitem
    {
        [Key]
        public int GrocId { get; set; }
        public string GrocName { get; set; }
        public double GrocPrice { get; set; }
        public int GrocQuantity { get; set; }
        public DateTime GrocTime { get; set; }
        
    }
}
