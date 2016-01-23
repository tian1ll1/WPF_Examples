using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    public partial class UserControl2 : UserControl, IObserver
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        #region IObserver ≥…‘±

        public void Update(object sender, SubjectEventArgs e)
        {
            this.label1.Text = e.Message;
        }

        #endregion
    }
}
