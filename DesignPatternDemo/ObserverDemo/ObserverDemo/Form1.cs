using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObserverDemo
{
    public partial class Form1 : Form
    {
        public SubjectClass subject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new SubjectClass();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            subject.notifier +=new SubjectClass.LoopNotifier(f.Update);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject.Notify(100);
        }
    }
}