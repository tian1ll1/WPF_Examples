using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrdCls;

namespace PrdCls.Test
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products = {
 　　　　　　new Product {Name = "AAA", Price = 275M},
 　　　　　　new Product {Name = "BBB", Price = 48.95M},
 　　　　　　new Product {Name = "CCC", Price = 19.50M},
　　　　　　 new Product {Name = "DDD", Price = 34.95M}
 　　　　};

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            // arrange
            var discounter = new PrdCls.MinDiscountHelper();
            var target = new LinqValueCalculator(discounter);
            
            var goalTotal = products.Sum(e => e.Price);
            // act
            var result = target.ValueProducts(products);
            // assert
            Assert.AreEqual(goalTotal, result);
        }
    }
}
