using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace PrdCls.Test
{
    [TestClass]
    public class UnitTestWithMoq
    {
        private Product[] InitProducts(decimal price)
        {
            return new Product[] { new Product { Price = price } };
        }

        /// <summary>
        /// 使用Moq辅助，单独测试跟其他模块有依赖关系的方法。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]        // 指定计划抛出的异常
        public void TestMethod1()
        {
            Mock<IDiscountHelper> mocker = new Mock<IDiscountHelper>();     // 创建Mock对象，伪造一个IDiscountHelper的实现
            /* 装载实现的GetDiscount方法。
             * Mock的装载方式是倒序，因此要最先写最基础的场景，往下装载特殊的场景。
             */
            mocker.Setup(m => m.GetDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);     // 装载方法
            mocker.Setup(m => m.GetDiscount(It.Is<decimal>(v => v == 0))).Throws<ArgumentOutOfRangeException>();     // 参数等于0时，抛出异常
            mocker.Setup(m => m.GetDiscount(It.Is<decimal>(v => v > 100))).Returns<decimal>(total => total * 0.9M);     // 参数大于100时，返回九折
            mocker.Setup(m => m.GetDiscount(It.IsInRange<decimal>(10, 100, Range.Inclusive))).Returns<decimal>(total => total - 5);      // 参数在10与100之间，包括10和100，返回-5

            var test = new LinqValueCalculator(mocker.Object);

            //decimal zero = test.ValueProducts(InitProducts(0M));
            decimal five = test.ValueProducts(InitProducts(5M));
            decimal ten = test.ValueProducts(InitProducts(10M));
            decimal fifty = test.ValueProducts(InitProducts(50M));
            decimal hundred = test.ValueProducts(InitProducts(100M));
            decimal twoHundred = test.ValueProducts(InitProducts(200M));

            Assert.AreEqual(5M, five, "Test Five failed");
            Assert.AreEqual(5M, ten, "Test Ten failed");
            Assert.AreEqual(45M, fifty, "Test Fifty failed");
            Assert.AreEqual(95M, hundred, "Test Hundred failed");
            Assert.AreEqual(200 * 0.9M, twoHundred, "Test TwoHundred failed");
            test.ValueProducts(InitProducts(0M));
        }
    }
}
