using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace InterpreterSample
{

	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
			this.btLeft = new System.Windows.Forms.Button();
			this.txtVar = new System.Windows.Forms.TextBox();
			this.btRight = new System.Windows.Forms.Button();
			this.btForward = new System.Windows.Forms.Button();
			this.btBackward = new System.Windows.Forms.Button();
			this.btRep = new System.Windows.Forms.Button();
			this.btParse = new System.Windows.Forms.Button();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btLeft
			// 
			this.btLeft.Location = new System.Drawing.Point(120, 8);
			this.btLeft.Name = "btLeft";
			this.btLeft.Size = new System.Drawing.Size(56, 23);
			this.btLeft.TabIndex = 0;
			this.btLeft.Text = "Left";
			this.btLeft.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtVar
			// 
			this.txtVar.Location = new System.Drawing.Point(8, 8);
			this.txtVar.Name = "txtVar";
			this.txtVar.TabIndex = 1;
			this.txtVar.Text = "90";
			this.txtVar.TextChanged += new System.EventHandler(this.txtVar_TextChanged);
			// 
			// btRight
			// 
			this.btRight.Location = new System.Drawing.Point(184, 8);
			this.btRight.Name = "btRight";
			this.btRight.Size = new System.Drawing.Size(56, 23);
			this.btRight.TabIndex = 2;
			this.btRight.Text = "Right";
			this.btRight.Click += new System.EventHandler(this.btRight_Click);
			// 
			// btForward
			// 
			this.btForward.Location = new System.Drawing.Point(248, 8);
			this.btForward.Name = "btForward";
			this.btForward.Size = new System.Drawing.Size(56, 23);
			this.btForward.TabIndex = 3;
			this.btForward.Text = "Forward";
			this.btForward.Click += new System.EventHandler(this.btForward_Click);
			// 
			// btBackward
			// 
			this.btBackward.Location = new System.Drawing.Point(312, 8);
			this.btBackward.Name = "btBackward";
			this.btBackward.TabIndex = 4;
			this.btBackward.Text = "Backward";
			this.btBackward.Click += new System.EventHandler(this.btBackward_Click);
			// 
			// btRep
			// 
			this.btRep.Location = new System.Drawing.Point(400, 8);
			this.btRep.Name = "btRep";
			this.btRep.TabIndex = 5;
			this.btRep.Text = "repTest";
			this.btRep.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btParse
			// 
			this.btParse.Location = new System.Drawing.Point(400, 48);
			this.btParse.Name = "btParse";
			this.btParse.TabIndex = 6;
			this.btParse.Text = "Parse";
			this.btParse.Click += new System.EventHandler(this.btParse_Click);
			// 
			// txtCommand
			// 
			this.txtCommand.Location = new System.Drawing.Point(8, 40);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(216, 21);
			this.txtCommand.TabIndex = 7;
			this.txtCommand.Text = "left 90";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(488, 333);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.btParse);
			this.Controls.Add(this.btRep);
			this.Controls.Add(this.btBackward);
			this.Controls.Add(this.btForward);
			this.Controls.Add(this.btRight);
			this.Controls.Add(this.txtVar);
			this.Controls.Add(this.btLeft);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private System.Windows.Forms.Button btLeft;
		private System.Windows.Forms.TextBox txtVar;
		private System.Windows.Forms.Button btRight;
		private System.Windows.Forms.Button btForward;
		private System.Windows.Forms.Button btBackward;
		private System.Windows.Forms.Button btRep;
		private System.Windows.Forms.Button btParse;
		private System.Windows.Forms.TextBox txtCommand;

		private Context ctx;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			Graphics g = this.CreateGraphics();
			ctx = new Context(this.Width/2,this.Height/2,90,g);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			ctx.DrawLocation();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int a = Convert.ToInt32(txtVar.Text);
			LeftExpression le = new LeftExpression(a);
			le.interpret(ctx);
			
		}

		private void txtVar_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btRight_Click(object sender, System.EventArgs e)
		{
			int a = Convert.ToInt32(txtVar.Text);
			RightExpression le = new RightExpression(a);
			le.interpret(ctx);
		}

		private void btForward_Click(object sender, System.EventArgs e)
		{
			int a = Convert.ToInt32(txtVar.Text);
			ForwardExpression le = new ForwardExpression(a);
			le.interpret(ctx);
		}

		private void btBackward_Click(object sender, System.EventArgs e)
		{
			int a = Convert.ToInt32(txtVar.Text);
			BackwardExpression le = new BackwardExpression(a);
			le.interpret(ctx);
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			LeftExpression le = new LeftExpression(30);
			ForwardExpression lf = new ForwardExpression(50);


			RepeatExpression re = new RepeatExpression(4);
			re.AddExpression(le);
			re.AddExpression(lf);
			re.interpret(ctx);
		}

		private void btParse_Click(object sender, System.EventArgs e)
		{
			Parser p = new Parser(this.txtCommand.Text );
			AbstractExpression a =p.Build ();
			a.interpret(ctx);
		}
	}
}
