using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfictionaryApp.Models
{
    public enum Unit
    {
        kg, lb
    }
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Unit? Unit { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
