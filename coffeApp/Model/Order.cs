using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int PointUse { get; set; }
        public bool Status { get; set;}
        public int Total { get; set; }
    }
}
