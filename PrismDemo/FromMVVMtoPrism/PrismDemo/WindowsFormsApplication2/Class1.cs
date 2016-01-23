using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class OurOwnEventArgs : EventArgs
    {
        public string MessageArgs = string.Empty;
    }

    public delegate void DemoDelg(object sender, OurOwnEventArgs e);
    public class Class1
    {
        public event DemoDelg DivideZeroEvent;
        public int Divide(int a, int b)
        {
            int result = 0;

            if (b == 0)
            {
                OurOwnEventArgs e = new OurOwnEventArgs();
                e.MessageArgs = "divide zero";

                DivideZeroEvent(this, e);
                //invoke event
            }
            else
            {
                result = a / b;
            }
            return result;
            //DemoDelg dlg = new DemoDelg
        }
    }
}
