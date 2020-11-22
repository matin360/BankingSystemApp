namespace BakingSystemUI.Forms
{
	partial class ConfigureForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.credentialsControl = new BakingSystemUI.Controls.RegLogControl();
			this.label4 = new System.Windows.Forms.Label();
			this.txbx_age = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbx_surname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbx_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.credentialsControl);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txbx_age);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txbx_surname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txbx_name);
			this.groupBox1.Location = new System.Drawing.Point(43, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(223, 378);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Info";
			// 
			// credentialsControl
			// 
			this.credentialsControl.Location = new System.Drawing.Point(30, 192);
			this.credentialsControl.Name = "credentialsControl";
			this.credentialsControl.Size = new System.Drawing.Size(166, 165);
			this.credentialsControl.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Age";
			// 
			// txbx_age
			// 
			this.txbx_age.Location = new System.Drawing.Point(16, 166);
			this.txbx_age.Name = "txbx_age";
			this.txbx_age.Size = new System.Drawing.Size(190, 20);
			this.txbx_age.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Surname";
			// 
			// txbx_surname
			// 
			this.txbx_surname.Location = new System.Drawing.Point(16, 105);
			this.txbx_surname.Name = "txbx_surname";
			this.txbx_surname.Size = new System.Drawing.Size(190, 20);
			this.txbx_surname.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Name";
			// 
			// txbx_name
			// 
			this.txbx_name.Location = new System.Drawing.Point(16, 45);
			this.txbx_name.Name = "txbx_name";
			this.txbx_name.Size = new System.Drawing.Size(190, 20);
			this.txbx_name.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Here you can configure your personal information";
			// 
			// ConfigureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 468);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ConfigureForm";
			this.Text = "ConfigureForm";
			this.Load += new System.EventHandler(this.ConfigureForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbx_age;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbx_surname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbx_name;
		private System.Windows.Forms.Label label1;
		private Controls.RegLogControl credentialsControl;
	}
}