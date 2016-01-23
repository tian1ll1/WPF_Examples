using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    class Class2
    {
         #region Singleton defination
        private readonly static Class2 uniqueObject = new Class2();

        private Class2()
        { }

        public static Class2 Instance
        {
            get {               
                return uniqueObject;
            }
        }

        public static Class2 GetInstance()
        {           
            return uniqueObject;
        }
        #endregion
    }
}
