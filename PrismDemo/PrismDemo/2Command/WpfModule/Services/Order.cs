using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfModule.Services
{
    public class Order
    {
        public Order()
        { }
        public string Name { get; set; }

        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Age { get; set; }
    }
}
