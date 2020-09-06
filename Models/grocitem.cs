using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreMgmt.Models
{
    public class grocitem
    {
        private GrocContext db;

        public grocitem()
        {

        }
        public grocitem(int GrocId, string GrocName, double GrocPrice, int GrocQuantity, DateTime GrocTime)
        {
            this.GrocId = GrocId;
            this.GrocName = GrocName;
            this.GrocPrice = GrocPrice;
            this.GrocQuantity = GrocQuantity;
            this.GrocTime = GrocTime;

        }
        public grocitem(GrocContext db)
        {
            this.db = db;
        }

        [Key]
        public int GrocId { get; set; }
        public string GrocName { get; set; }
        public double GrocPrice { get; set; }
        public int GrocQuantity { get; set; }
        public DateTime GrocTime { get; set; }

        public static object AsQueryable()
        {
            throw new NotImplementedException();
        }
    }
}
