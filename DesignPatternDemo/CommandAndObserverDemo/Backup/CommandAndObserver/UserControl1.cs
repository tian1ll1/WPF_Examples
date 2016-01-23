using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    public partial class UserControl1 : UserControl, IObserver
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        #region IObserver ≥…‘±

        public void Update(object sender, SubjectEventArgs e)
        {
            this.textBox1.Text = e.Message;
        }

        #endregion
    }
}
