using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
    public interface IDemo
    {
        string GetString(); //virtual
    }
    class Class1 : IDemo
    {
        #region IDemo 成员

        public string GetString()  // override
        {
            return "Class1 String!";
        }

        #endregion
    }

    class Class2 : IDemo
    {
        #region IDemo 成员

        public string GetString()
        {
            return "Class2 String!";
        }

        #endregion
    }
}
