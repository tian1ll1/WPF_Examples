using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    public partial class TestForm : Form
    {
        private Subject _Subject;

        public TestForm()
        {
            InitializeComponent();
        }
        public TestForm(string uid)
        {
            InitializeComponent();

            this.label1.Text = uid;
        }

        public Subject OriginalSubject
        {
            set {
                _Subject = value;
                _Subject.AddObServer(this.userControl11);
                _Subject.AddObServer(this.userControl21);
            }
        }


        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}