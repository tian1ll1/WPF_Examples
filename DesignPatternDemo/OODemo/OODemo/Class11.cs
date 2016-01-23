using System;
using System.Collections.Generic;
using System.Text;

namespace OODemo
{
    class Class11
    {
        public string HandleIDemo(IDemo dm)
        {
            return dm.GetString();
        }

    }
}
