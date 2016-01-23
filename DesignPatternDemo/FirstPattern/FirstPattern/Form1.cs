using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person("Ray Ozzie");
            p.MyHat = new Hat("Tennis Hat");

            p.PlayTennis();

            if (p.MyHat == null)
                MessageBox.Show("without hat");
            else
                MessageBox.Show(string.Format("With {0}", p.MyHat.HatType));

        }
    }
}