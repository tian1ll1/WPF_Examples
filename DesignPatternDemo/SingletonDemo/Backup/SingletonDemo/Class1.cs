using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    class Class1
    {
        #region Singleton defination
        private static Class1 uniqueObject;

        private Class1()
        { }

        public static Class1 Instance
        {
            get {
                if (uniqueObject == null)
                    uniqueObject = new Class1();
                return uniqueObject;
            }
        }

        public static Class1 GetInstance()
        {
            //return Class1.Instance;

            if (uniqueObject == null)
                uniqueObject = new Class1();
            return uniqueObject;
        }
        #endregion

        public string GetCustoemrName()
        {
            return "John";
        }


    }
}
