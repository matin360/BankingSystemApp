namespace BakingSystemUI.Controls
{
	partial class RegLogControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txbx_email = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbx_password = new System.Windows.Forms.TextBox();
			this.btn_submit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Email";
			// 
			// txbx_email
			// 
			this.txbx_email.Location = new System.Drawing.Point(6, 35);
			this.txbx_email.Name = "txbx_email";
			this.txbx_email.Size = new System.Drawing.Size(157, 20);
			this.txbx_email.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// txbx_password
			// 
			this.txbx_password.Location = new System.Drawing.Point(6, 94);
			this.txbx_password.Name = "txbx_password";
			this.txbx_password.Size = new System.Drawing.Size(157, 20);
			this.txbx_password.TabIndex = 4;
			this.txbx_password.UseSystemPasswordChar = true;
			// 
			// btn_submit
			// 
			this.btn_submit.Location = new System.Drawing.Point(46, 138);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(75, 23);
			this.btn_submit.TabIndex = 6;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = true;
			// 
			// RegLogControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_submit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbx_password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbx_email);
			this.Name = "RegLogControl";
			this.Size = new System.Drawing.Size(166, 165);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txbx_email;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txbx_password;
		public System.Windows.Forms.Button btn_submit;
	}
}
