using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.Model
{
	public class Product
	{
		public int DrinkId { get; set; }
		public string DrinkName { get; set; }
		public decimal Price { get; set; }
		public decimal Cost { get; set; }
		public string Provider { get; set; }	
	}
}
