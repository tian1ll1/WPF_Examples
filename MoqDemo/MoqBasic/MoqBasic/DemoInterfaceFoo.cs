using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasic
{
    public delegate void MyEventHandler(int i, bool b);
    public  delegate void MyFooEventHandler(FooEventArgs args);
    public interface IFoo
    {
        event MyEventHandler MyEvent;

        event MyFooEventHandler FooEvent;
       string DoSomething(string str);
     
       bool TryParse(string strA, out string strB);

       bool Submit(ref Bar b);

       bool Submit();

       int GetCount();

        int GetCountThing();

        int Add(int a);

        IFoo Child{get; set;}
    }

    public class FooEventArgs
    {
        public FooEventArgs(string value)
        { }
    }

    public class Bar
    { }


}
