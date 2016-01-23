using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
   public abstract class Class3
    {
       public abstract string GetString(); // virtual

       public virtual string GetDemoString()
       {
           return "Parent Class3";
       }

       public  string GetDemoStringEx()
       {
           return "Parent Class3 Ex";
       }

       public int Add(int x, int y)
       {
           return x + y;
       }

       public string Name
       {
           get;
           set;
       }

       //public abstract string Email { get; set; }
       
    }

    class Class4 : Class3
    {
        public new string GetDemoStringEx()
        {
            return " Class4 Ex";
        }
        public override string GetString() // ∂‡Ã¨£¨±‰ªØ
        {
            return "Class4 string!";
        }

        public override string GetDemoString()
        {
            return "Class4  demo string";
        }
        
    }

    class Class5 : Class3
    {
        public override string GetString()
        {
            return "Class5 string!";
        }

        public override string GetDemoString()
        {
            return "Class5  demo string";
        }
    }
}
