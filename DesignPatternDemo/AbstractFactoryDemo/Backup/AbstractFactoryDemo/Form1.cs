using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;

namespace AbstractFactoryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            DBFactory factory =  new ODBCFactory();
            

            DBAccess dba = new DBAccess(factory);
            dba.Open("connectionString");
            DataSet ds = dba.ExecSQL("select * from persons.Address");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conf = ConfigurationManager.AppSettings["DBAccess"].ToString().Trim();

            Assembly asm = Assembly.GetExecutingAssembly();
           
            Type t = asm.GetType(conf);
            DBFactory factory = (DBFactory) Activator.CreateInstance(t);

             DBAccess dba = new DBAccess(factory);
            dba.Open("connectionString");
            DataSet ds = dba.ExecSQL("select * from persons.Address");
        }
    }
}