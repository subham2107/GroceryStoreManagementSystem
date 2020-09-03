using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Models
{
    public class grocsell
    {
        [Key]
        public int SellId { get; set; }
        public int GrocId { get; set; } //foreign key referencing the grocitem table
        public string CustName { get; set; }
        public int GrocQuantity { get; set; }
        public DateTime GrocBuyTime { get; set; }
    }
}
