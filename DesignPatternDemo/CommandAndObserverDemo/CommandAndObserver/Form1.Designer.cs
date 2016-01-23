namespace CommandAndObserver
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetailParty = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControl11 = new CommandAndObserver.UserControl1();
            this.SuspendLayout();
            // 
            // btnDetailParty
            // 
            this.btnDetailParty.Location = new System.Drawing.Point(56, 134);
            this.btnDetailParty.Name = "btnDetailParty";
            this.btnDetailParty.Size = new System.Drawing.Size(75, 21);
            this.btnDetailParty.TabIndex = 0;
            this.btnDetailParty.Text = "button1";
            this.btnDetailParty.UseVisualStyleBackColor = true;
            //this.btnDetailParty.Click += new System.EventHandler(this.btnDetailParty_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(72, 215);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(272, 129);
            this.userControl11.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 408);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDetailParty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetailParty;
        private System.Windows.Forms.TextBox textBox1;
        private UserControl1 userControl11;
    }
}

