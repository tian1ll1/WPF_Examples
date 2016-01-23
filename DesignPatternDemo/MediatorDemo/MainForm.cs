using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mediator
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btRemove;
		private System.Windows.Forms.ListBox lstAll;
		private System.Windows.Forms.ListBox lstSelected;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lstAll = new System.Windows.Forms.ListBox();
			this.lstSelected = new System.Windows.Forms.ListBox();
			this.btAdd = new System.Windows.Forms.Button();
			this.btRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstAll
			// 
			this.lstAll.ItemHeight = 12;
			this.lstAll.Location = new System.Drawing.Point(8, 16);
			this.lstAll.Name = "lstAll";
			this.lstAll.Size = new System.Drawing.Size(112, 244);
			this.lstAll.TabIndex = 0;
			this.lstAll.SelectedIndexChanged += new System.EventHandler(this.lstAll_SelectedIndexChanged);
			// 
			// lstSelected
			// 
			this.lstSelected.ItemHeight = 12;
			this.lstSelected.Location = new System.Drawing.Point(168, 16);
			this.lstSelected.Name = "lstSelected";
			this.lstSelected.Size = new System.Drawing.Size(120, 244);
			this.lstSelected.TabIndex = 1;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(128, 80);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(32, 23);
			this.btAdd.TabIndex = 2;
			this.btAdd.Text = ">>";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// btRemove
			// 
			this.btRemove.Location = new System.Drawing.Point(128, 192);
			this.btRemove.Name = "btRemove";
			this.btRemove.Size = new System.Drawing.Size(32, 23);
			this.btRemove.TabIndex = 3;
			this.btRemove.Text = "<<";
			this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 273);
			this.Controls.Add(this.btRemove);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.lstSelected);
			this.Controls.Add(this.lstAll);
			this.Name = "MainForm";
			this.Text = "Mediator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			lstAll.Items.Add ("苹果");
			lstAll.Items.Add("香蕉");
			lstAll.Items.Add("橘子");
			lstAll.Items.Add("西瓜");
			lstAll.Items.Add("葡萄");
			//MessageBox.Show(lstAll.Parent.Name); 
		}


		private void btAdd_Click(object sender, System.EventArgs e)
		{
			Object o = lstAll.SelectedItem;
			if (o!=null)
			{
				lstAll.Items.Remove(o);
				lstSelected.Items.Add(o);
			}
		}

		private void btRemove_Click(object sender, System.EventArgs e)
		{
			Object o = lstSelected.SelectedItem;
			if (o!=null)
			{
				lstSelected.Items.Remove(o);
				lstAll.Items.Add(o);
			}
		}

		private void lstAll_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
