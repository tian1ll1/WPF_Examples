using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
    public interface IDemo
    {
        string GetString();
    }
    class Class1 : IDemo
    {
        #region IDemo ��Ա

        public string GetString()
        {
            return "Class1 String!";
        }

        #endregion
    }

    class Class2 : IDemo
    {
        #region IDemo ��Ա

        public string GetString()
        {
            return "Class2 String!";
        }

        #endregion
    }
}
