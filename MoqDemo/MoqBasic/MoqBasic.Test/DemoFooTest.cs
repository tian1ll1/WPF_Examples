using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace MoqBasic.Test
{
    [TestClass]
    public class DemoFooTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns("str");


            // out arguments
            var outString = "ack";
            // TryParse will return true, and the out argument will return "ack", lazy evaluated
            mock.Setup(foo => foo.TryParse("ping", out outString)).Returns(true);


            // ref arguments
            var instance = new Bar();
            // Only matches if the ref argument to the invocation is the same instance
            mock.Setup(foo => foo.Submit(ref instance)).Returns(true);


            // access invocation arguments when returning a value
            mock.Setup(x => x.DoSomething(It.IsAny<string>()))
                    .Returns((string s) => s.ToLower());
            // Multiple parameters overloads available


            // throwing when invoked
            mock.Setup(foo => foo.DoSomething("reset")).Throws<InvalidOperationException>();
            mock.Setup(foo => foo.DoSomething("")).Throws(new ArgumentException("command"));


            // lazy evaluating return value
            mock.Setup(foo => foo.GetCount()).Returns((int count) => count);


            // returning different values on each invocation
            var mock1 = new Mock<IFoo>();
            var calls = 0;
            mock1.Setup(foo => foo.GetCountThing())
                .Returns(() => calls)
                .Callback(() => calls++);
            // returns 0 on first invocation, 1 on the next, and so on
            // Console.WriteLine(mock.Object.GetCountThing());

            //set parameters
            // any value
            mock.Setup(foo => foo.DoSomething(It.IsAny<string>())).Returns("h");


            // matching Func<int>, lazy evaluated
            mock.Setup(foo => foo.Add(It.Is<int>(i => i % 2 == 0))).Returns(3);


            // matching ranges
            mock.Setup(foo => foo.Add(It.IsInRange<int>(0, 10, Range.Inclusive))).Returns(4);           
        }

        [TestMethod]
        public void TestMethodEvent()
        {
              var mock = new Mock<IFoo>();
              string fooValue = "hello";
            // Raising an event on the mock
         mock.Raise(m => m.FooEvent += null, new FooEventArgs(fooValue));

       }
    }
}
