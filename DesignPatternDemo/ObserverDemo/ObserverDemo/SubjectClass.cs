using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo
{
   public class SubjectClass
    {
       public delegate void LoopNotifier(int i, int j);

       public event LoopNotifier notifier;

       public SubjectClass()
       { }

       public void Notify(int loopNum)
       {
           if (notifier != null)
           {
               for (int i = 0; i < loopNum; i++)
               {
                   for (int j = 0; j < loopNum; j++)
                   {
                       notifier(i, j);
                   }
               }
           }
       }
   }
}
