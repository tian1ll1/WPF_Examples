using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FactoryMethodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bird creator = new Duck();
            Egg eg = creator.LayEgg(); //duck egg

            creator = new Goose();
            eg = creator.LayEgg(); // goose egg
        }
    }
}