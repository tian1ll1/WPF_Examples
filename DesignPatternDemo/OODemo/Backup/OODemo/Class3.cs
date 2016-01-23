using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
   abstract class Class3
    {
       public abstract string GetString();
    }

    class Class4 : Class3
    {
        public override string GetString()
        {
            return "Class4 string!";
        }
    }

    class Class5 : Class3
    {
        public override string GetString()
        {
            return "Class5 string!";
        }
    }
}
