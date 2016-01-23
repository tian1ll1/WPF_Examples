using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrdCls
{
    public class MinDiscountHelper : IDiscountHelper
    {

        public decimal GetDiscount(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (price > 10 && price <= 100)
            {
                return price - 5;
            }
            else if (price > 100)
            {
                return price * 0.9M;
            }
            else
            {
                return price;
            }
        }
    }
}
