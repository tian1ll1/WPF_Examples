using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RefinedBuilderLib;

namespace RefinedBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinBuilder win = new WinBuilder();
            List<UIFieldDescription> controlDesc = new List<UIFieldDescription>();
            controlDesc.Add(new UIFieldDescription("姓名", "ｔext", "FullName", "FullName"));
            controlDesc.Add(new UIFieldDescription("性别", "select", "Gender", "Gender"));
            controlDesc.Add(new UIFieldDescription("住址", "text", "Address", "Address"));
            controlDesc.Add(new UIFieldDescription("年龄", "text", "Age", "Age"));
            controlDesc.Add(new UIFieldDescription("Email", "text", "Email", "Email"));

            UIDirector director = new UIDirector(win);
            director.Build(controlDesc);

            Panel p = win.GetUI();
            p.Height = 400;
            p.Width = 300;
            this.Controls.Add(p);
        }
    }
}