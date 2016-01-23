using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrdCls
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper discountPara)
        {
            this.discounter = discountPara;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return this.discounter.GetDiscount(products.Sum(p => p.Price));
        }
    }
}
