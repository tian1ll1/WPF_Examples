using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BetterAddHatAndBehavior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Play("Swimming");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //帽子不是由行为决定，而是由使用方决定，这有可能会出现带着泳帽去打网球的情况
            Person p = new Person();
            p.MyHat = new SwimmingHat();
            p.Play("Swimming");

            p.MyHat = new TennisHat();
            p.Play("Play Tennis");
        }
    }
}