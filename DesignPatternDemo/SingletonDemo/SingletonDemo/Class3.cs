using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    class Class3
    {
         #region Singleton defination
        private readonly static object obj = new object();
        private static Class3 uniqueObject;

        private Class3()
        { }

        public static Class3 Instance
        {
            get {
                lock (Class3.obj)
                {
                    if (Class3.uniqueObject == null)
                        Class3.uniqueObject = new Class3();
                
                    }
                return uniqueObject;
            }
        }

        public static Class3 GetInstance()
        {
            lock (Class3.obj)
            {
                if (Class3.uniqueObject == null)
                    Class3.uniqueObject = new Class3();

            }
            return uniqueObject;
        }
        #endregion
    }
}
