using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace PrototypeDemo
{
    public class ProTextBox : TextBox, ICloneable
    {
        public ProTextBox()
        { }

        #region ICloneable 成员

        public object Clone()
        {
            TextBox txb = new TextBox();

            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if(p.CanWrite & p.CanRead)
                    p.SetValue(txb, p.GetValue(this, null), null);
            }
            

            return txb;
        }

        #endregion
    }

    public class ProLabel : Label, ICloneable
    {
        public ProLabel()
        {}

        #region ICloneable 成员

        public object Clone()
        {
            Label lbl = new Label();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (p.CanWrite & p.CanRead)
                    p.SetValue(lbl, p.GetValue(this, null), null);
            }         
            return lbl;
        }

        #endregion
    }
    public class ControlFactory
    {
        private Hashtable controls = new Hashtable();

        public Hashtable Controls
        {
            get { return controls; }
            set { controls = value; }
        }

        public ControlFactory()
        {
            controls.Add("label" ,new ProLabel());
            ProTextBox txb = new ProTextBox();
            txb.Text = "wowow";
            controls.Add("textbox", txb);
        }
    }
}
