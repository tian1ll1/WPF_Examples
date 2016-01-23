using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
   public class Class6
    {
        public virtual string GetString()
        {
            return string.Empty;
        }

       public string GetStringEx()
       {
           return "parent string!";
       }
    }

    public class HandleClass6
    {
        public string GetClass6String(Class6 parent)
        {
            return parent.GetString() + " : " + parent.GetStringEx();
        }
    }

    public class Class7 : Class6
    {
        public override string GetString()
        {
            return "class 7 string";
        }

        public new string GetStringEx()
        {
            return "class7 new string!";
        }
    }

    public class Class8 : Class6
    {
        public override string GetString()
        {
            return "class 8 string";
        }
    }
}
