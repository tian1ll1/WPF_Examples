using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
    public class OOHandler
    {
        public OOHandler()
        { }

        public string HandleParentObject(Class3 obj)
        {
            return obj.GetDemoString();
        }
    }
}
