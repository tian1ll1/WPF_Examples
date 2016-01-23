using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqBasic.Test
{
    [TestClass]
    public class DemoLibTest
    {
        /// <summary>
        /// 测试接口
        /// </summary>
        [TestMethod()]
        public void TestInterface()
        {
            var test = new Mock<ITest>();
            test.Setup(p => p.ShowMsg()).Returns("Hello World~");
            Assert.AreEqual("Hello World~", test.Object.ShowMsg());
        }

        /// <summary>
        /// 测试接口参数
        /// </summary>
        [TestMethod()]
        public void TestInterfaceWithParam()
        {
            var testMatch = new Mock<IMatchTest>();
            testMatch.Setup(p => p.MathDiv(It.Is<int>(i => i % 2 == 0))).Returns("偶数");
            testMatch.Setup(p => p.MathDiv(It.Is<int>(i => i % 2 != 0))).Returns("奇数");
            Assert.AreEqual("偶数", testMatch.Object.MathDiv(4));
            Assert.AreEqual("奇数", testMatch.Object.MathDiv(3));
        }

        /// <summary>
        /// 测试属性
        /// </summary>
        [TestMethod()]
        public void TestInterfaceWithProperty()
        {
            var testProperties = new Mock<IPropertiesTest>();
            testProperties.Setup(p => p.UserInfo).Returns(1);
            Assert.AreEqual(1, testProperties.Object.UserInfo);            
        }

        /// <summary>
        /// 测试属性Ex
        /// </summary>
        [TestMethod()]
        public void TestInterfaceWithPropertyEx()
        {
            var testProperties = new Mock<IPropertiesTest>();
            testProperties.SetupProperty(p => p.UserInfo, 1);
            Assert.AreEqual(1, testProperties.Object.UserInfo);
        }

        /// <summary>
        /// 测试Callback
        /// </summary>
        [TestMethod()]
        public void TestInterfaceWithPropertyCallBack()
        {
            int count = 0;
            var testProperties = new Mock<IPropertiesTest>();            
            testProperties.Setup(p => p.UserInfo).Returns(1).Callback(() => count++);
           Assert.AreEqual(1, testProperties.Object.UserInfo);
            Assert.AreEqual(1, count);
        }

        /// <summary>
        /// 验证属性是否执行过
        /// </summary>
        [TestMethod()]
        public void TestInterfaceWithPropertyVerification()
        {
            var testProperties = new Mock<IPropertiesTest>();
            testProperties.Setup(p => p.UserInfo).Returns(1);
            //Assert.AreEqual(1, testProperties.Object.UserInfo);
            testProperties.Verify(p => p.UserInfo);
            Assert.AreEqual(1, testProperties.Object.UserInfo);
        }




    }
}
