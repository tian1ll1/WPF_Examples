using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDemo demo;

            Class1 c1 = new Class1();
            demo = c1; //上溯造型,父类（接口）变量指向子类对象。

           MessageBox.Show(  demo.GetString());

            Class2 c2 = new Class2();

            demo = c2;
            MessageBox.Show( demo.GetString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class3 parent;

            Class4 c4 = new Class4();
            parent = c4; //上溯造型,父类（接口）变量指向子类对象。
            MessageBox.Show(parent.GetString());

            Class5 c5 = new Class5();
            parent = c5; //上溯造型,父类（接口）变量指向子类对象。
            MessageBox.Show(parent.GetString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class6 parent;

            Class7 c7 = new Class7();
            parent = c7; //上溯造型,父类（接口）变量指向子类对象。
           //MessageBox.Show(parent.GetString());
            MessageBox.Show(parent.GetStringEx());

            Class8 c8 = new Class8();
            parent = c8;
            //MessageBox.Show(parent.GetString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleClass6 h = new HandleClass6();
            Class7 c7 = new Class7();
            //Class6 parent = c7;
            //h.GetClass6String(parent);
           MessageBox.Show( h.GetClass6String(c7));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleClass6 h = new HandleClass6();
            Class9 c9 = new Class9();
            //Class6 parent = c7;
            //h.GetClass6String(parent);
            MessageBox.Show(h.GetClass6String(c9));
        }
    }
}