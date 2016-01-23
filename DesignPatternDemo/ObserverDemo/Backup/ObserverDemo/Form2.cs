using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObserverDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Update(int i , int j)
        {
            this.label1.Text = string.Format("{0},{1}", i.ToString(), j.ToString());
            this.label1.Refresh();
            this.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}