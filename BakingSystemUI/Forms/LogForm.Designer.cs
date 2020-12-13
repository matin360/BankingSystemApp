namespace BakingSystemUI
{
	partial class LogForm
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
			this.logControl = new BakingSystemUI.Controls.RegLogControl();
			this.grbx_reg = new System.Windows.Forms.GroupBox();
			this.regControl = new BakingSystemUI.Controls.RegLogControl();
			this.grbx_log.SuspendLayout();
			this.grbx_reg.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbx_log
			// 
			this.grbx_log.Controls.Add(this.logControl);
			this.grbx_log.Location = new System.Drawing.Point(280, 7);
			this.grbx_log.Name = "grbx_log";
			this.grbx_log.Size = new System.Drawing.Size(256, 247);
			this.grbx_log.TabIndex = 3;
			this.grbx_log.TabStop = false;
			this.grbx_log.Text = "Login";
			// 
			// logControl
			// 
			this.logControl.Location = new System.Drawing.Point(42, 46);
			this.logControl.Name = "logControl";
			this.logControl.Size = new System.Drawing.Size(166, 165);
			this.logControl.TabIndex = 1;
			// 
			// grbx_reg
			// 
			this.grbx_reg.Controls.Add(this.regControl);
			this.grbx_reg.Location = new System.Drawing.Point(3, 7);
			this.grbx_reg.Name = "grbx_reg";
			this.grbx_reg.Size = new System.Drawing.Size(256, 247);
			this.grbx_reg.TabIndex = 2;
			this.grbx_reg.TabStop = false;
			this.grbx_reg.Text = "Register";
			// 
			// regControl
			// 
			this.regControl.Location = new System.Drawing.Point(41, 46);
			this.regControl.Name = "regControl";
			this.regControl.Size = new System.Drawing.Size(166, 165);
			this.regControl.TabIndex = 0;
			this.regControl.Load += new System.EventHandler(this.regControl_Load);
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 261);
			this.Controls.Add(this.grbx_log);
			this.Controls.Add(this.grbx_reg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LogForm";
			this.Text = "BankingSystem";
			this.grbx_log.ResumeLayout(false);
			this.grbx_reg.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_log;
		private System.Windows.Forms.GroupBox grbx_reg;
		private Controls.RegLogControl logControl;
		private Controls.RegLogControl regControl;
	}
}

