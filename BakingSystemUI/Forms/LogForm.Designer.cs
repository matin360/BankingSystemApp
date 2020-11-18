namespace BakingSystemUI
{
	partial class MainFrom
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grbx_log = new System.Windows.Forms.GroupBox();
			this.grbx_reg = new System.Windows.Forms.GroupBox();
			this.regLogControl1 = new BakingSystemUI.Controls.RegLogControl();
			this.regLogControl2 = new BakingSystemUI.Controls.RegLogControl();
			this.grbx_log.SuspendLayout();
			this.grbx_reg.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbx_log
			// 
			this.grbx_log.Controls.Add(this.regLogControl1);
			this.grbx_log.Location = new System.Drawing.Point(280, 7);
			this.grbx_log.Name = "grbx_log";
			this.grbx_log.Size = new System.Drawing.Size(256, 247);
			this.grbx_log.TabIndex = 3;
			this.grbx_log.TabStop = false;
			this.grbx_log.Text = "Login";
			// 
			// grbx_reg
			// 
			this.grbx_reg.Controls.Add(this.regLogControl2);
			this.grbx_reg.Location = new System.Drawing.Point(3, 7);
			this.grbx_reg.Name = "grbx_reg";
			this.grbx_reg.Size = new System.Drawing.Size(256, 247);
			this.grbx_reg.TabIndex = 2;
			this.grbx_reg.TabStop = false;
			this.grbx_reg.Text = "Register";
			// 
			// regLogControl1
			// 
			this.regLogControl1.Location = new System.Drawing.Point(18, 19);
			this.regLogControl1.Name = "regLogControl1";
			this.regLogControl1.Size = new System.Drawing.Size(212, 220);
			this.regLogControl1.TabIndex = 0;
			// 
			// regLogControl2
			// 
			this.regLogControl2.Location = new System.Drawing.Point(22, 19);
			this.regLogControl2.Name = "regLogControl2";
			this.regLogControl2.Size = new System.Drawing.Size(212, 220);
			this.regLogControl2.TabIndex = 1;
			// 
			// MainFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 261);
			this.Controls.Add(this.grbx_log);
			this.Controls.Add(this.grbx_reg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainFrom";
			this.Text = "BankingSystem";
			this.grbx_log.ResumeLayout(false);
			this.grbx_reg.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_log;
		private Controls.RegLogControl regLogControl1;
		private System.Windows.Forms.GroupBox grbx_reg;
		private Controls.RegLogControl regLogControl2;
	}
}

