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
          //  MessageBox.Show(parent.GetString());

            this.textBox1.Text = parent.GetDemoString();

            Class5 c5 = new Class5();
            parent = c5; //上溯造型,父类（接口）变量指向子类对象。
            //MessageBox.Show(parent.GetDemoString());

            this.textBox2.Text = parent.GetDemoString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class6 parent;

            Class7 c7 = new Class7();
            parent = c7; //上溯造型,父类（接口）变量指向子类对象。
           MessageBox.Show(parent.GetString());
            MessageBox.Show(parent.GetStringEx());

            //Class8 c8 = new Class8();
            //parent = c8;
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

        private void button6_Click(object sender, EventArgs e)
        {
            HandleClass6 h = new HandleClass6();
            Class7 childObj = new Class7();

            Class6 parentPnt = childObj;

            MessageBox.Show(parentPnt.GetString()); // virtual
            MessageBox.Show(parentPnt.GetStringEx());
            
            
            
            ////父类变量指向之类的对象，上溯造型
            ////由父类变量实现的方法调用，如果该方法是虚方法，并且子类中实现override，那么
            ////调用的实际上就是子类方法。
            //Class6 newobj = new Class14();
            ////reflection
            ////MEF

            //MessageBox.Show(h.GetClass6String(newobj));//?

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleClass6 h = new HandleClass6();
            Class10 childObj = new Class10();
            MessageBox.Show(h.GetClass6String(childObj));//?
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Class11().HandleIDemo(new Class1()));

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OOHandler o = new OOHandler();
            Class3 parent;
            parent = new Class4();
            this.textBox1.Text =  o.HandleParentObject(parent);

            parent = new Class5();
            this.textBox2.Text =  o.HandleParentObject(parent);
        }
    }
}