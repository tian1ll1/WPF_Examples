using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    public partial class Form1 : Form, IObserver
    {

        private Subject _Subject;
        private TestCommand detailCommand ;
       
        public Form1()
        {
            InitializeComponent();
            detailCommand = new TestCommand(this.DetailPreAction, this.AfterAction);
            this.detailCommand.ConnectUI(this.btnDetailParty);
        }    
      
        public void DetailPreAction()
        {
            detailCommand.UserID = this.textBox1.Text;            

            MessageBox.Show("PreAction");
            this._Subject.SubjectData = this.textBox1.Text;
            this._Subject.Notify();
        }

        public void AfterAction()
        {
            MessageBox.Show("After Action!");
        }


        #region IObserver ≥…‘±

        public void Update(object sender, SubjectEventArgs e)
        {
            MessageBox.Show("Observer Form1 : " + e.Message);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this._Subject = new Subject(string.Empty);
            this._Subject.AddObServer(this.userControl11);
            this.detailCommand.OriginalSubject = this._Subject;
            
        }

      

       
    }
}