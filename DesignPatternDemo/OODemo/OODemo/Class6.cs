using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
   public class Class6
    {
        public virtual string GetString()
        {
            return "parent virtual string!";
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
            //Child override string  ;            //Parent string!
            //1. child                        parent
            //2. parent                      parent
            //3. child                      child

            return parent.GetString();// +" : " + parent.GetStringEx();
        }
    }

    public class Class7 : Class6
    {
        public override string GetString()
        {
            return "Child override string";
        }

        public new string GetStringEx()
        {
            return "Child new string!";
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
