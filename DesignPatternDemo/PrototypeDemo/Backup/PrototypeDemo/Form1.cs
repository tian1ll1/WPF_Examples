using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrototypeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlFactory factory = new ControlFactory();
            object o = factory.Controls["textbox"];
            ICloneable clone = (ICloneable)o;
            Control c = clone.Clone() as Control;
            c.Location = new Point(80, 100);
            this.Controls.Add(c);

           this.Controls.Add(((ICloneable)factory.Controls["label"]).Clone() as Control);
            
        }
    }
}