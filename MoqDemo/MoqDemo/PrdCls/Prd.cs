using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrdCls
{
    public class Product
    {
        public string Name { set; get; }
        public string Category { get; set; }
        public decimal Price { set; get; }
    }

    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }

    public interface IDiscountHelper
    {
        decimal GetDiscount(decimal price);
    }
}
