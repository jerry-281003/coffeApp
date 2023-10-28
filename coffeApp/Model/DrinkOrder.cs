using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.Model
{
    public class DrinkOrder
    {
        public int DrinkOrderId { get; set; }
        public int DrinkId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
	}
       
    
}
