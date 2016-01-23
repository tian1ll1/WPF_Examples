using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    //public delegate void DemoDelg();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            cls.DivideZeroEvent += cls_DivideZeroEvent;
            cls.Divide(100, 0);
        }

        void cls_DivideZeroEvent(object sender, OurOwnEventArgs e)
        {
            MessageBox.Show(e.MessageArgs);
        }

        void cls_DivideZeroEvent()
        {
            MessageBox.Show("test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DemoDelg dlg = new DemoDelg(this.Showmsg);

            //dlg(); // anonymous invoke, delegate -> anonymous method pointer

            //dlg += new DemoDelg(this.Showmsg1);
        }

        public void Showmsg()
        {
            MessageBox.Show("test");
        
        }

        public void Showmsg1()
        {
            MessageBox.Show("test");

        }
    }   
}
