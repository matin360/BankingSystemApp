namespace BakingSystemUI.Forms
{
	partial class AdminForm
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
			this.grbx_admin = new System.Windows.Forms.GroupBox();
			this.link_cards = new System.Windows.Forms.LinkLabel();
			this.link_users = new System.Windows.Forms.LinkLabel();
			this.link_refresh = new System.Windows.Forms.LinkLabel();
			this.link_logOut = new System.Windows.Forms.LinkLabel();
			this.dgv_data = new System.Windows.Forms.DataGridView();
			this.grbx_admin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
			this.SuspendLayout();
			// 
			// grbx_admin
			// 
			this.grbx_admin.Controls.Add(this.link_refresh);
			this.grbx_admin.Controls.Add(this.link_logOut);
			this.grbx_admin.Controls.Add(this.link_cards);
			this.grbx_admin.Controls.Add(this.link_users);
			this.grbx_admin.Location = new System.Drawing.Point(12, 12);
			this.grbx_admin.Name = "grbx_admin";
			this.grbx_admin.Size = new System.Drawing.Size(699, 70);
			this.grbx_admin.TabIndex = 4;
			this.grbx_admin.TabStop = false;
			this.grbx_admin.Text = "Stats";
			// 
			// link_cards
			// 
			this.link_cards.AutoSize = true;
			this.link_cards.Location = new System.Drawing.Point(90, 31);
			this.link_cards.Name = "link_cards";
			this.link_cards.Size = new System.Drawing.Size(34, 13);
			this.link_cards.TabIndex = 1;
			this.link_cards.TabStop = true;
			this.link_cards.Text = "Cards";
			this.link_cards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cards_LinkClicked);
			// 
			// link_users
			// 
			this.link_users.AutoSize = true;
			this.link_users.Location = new System.Drawing.Point(12, 31);
			this.link_users.Name = "link_users";
			this.link_users.Size = new System.Drawing.Size(34, 13);
			this.link_users.TabIndex = 0;
			this.link_users.TabStop = true;
			this.link_users.Text = "Users";
			this.link_users.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_users_LinkClicked);
			// 
			// link_refresh
			// 
			this.link_refresh.AutoSize = true;
			this.link_refresh.Location = new System.Drawing.Point(649, 48);
			this.link_refresh.Name = "link_refresh";
			this.link_refresh.Size = new System.Drawing.Size(44, 13);
			this.link_refresh.TabIndex = 8;
			this.link_refresh.TabStop = true;
			this.link_refresh.Text = "Refresh";
			this.link_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_refresh_LinkClicked);
			// 
			// link_logOut
			// 
			this.link_logOut.AutoSize = true;
			this.link_logOut.Location = new System.Drawing.Point(649, 21);
			this.link_logOut.Name = "link_logOut";
			this.link_logOut.Size = new System.Drawing.Size(45, 13);
			this.link_logOut.TabIndex = 7;
			this.link_logOut.TabStop = true;
			this.link_logOut.Text = "Log Out";
			this.link_logOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logOut_LinkClicked);
			// 
			// dgv_data
			// 
			this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_data.Location = new System.Drawing.Point(1, 82);
			this.dgv_data.Name = "dgv_data";
			this.dgv_data.Size = new System.Drawing.Size(722, 330);
			this.dgv_data.TabIndex = 5;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 413);
			this.Controls.Add(this.dgv_data);
			this.Controls.Add(this.grbx_admin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.grbx_admin.ResumeLayout(false);
			this.grbx_admin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_admin;
		private System.Windows.Forms.LinkLabel link_cards;
		private System.Windows.Forms.LinkLabel link_users;
		private System.Windows.Forms.LinkLabel link_refresh;
		private System.Windows.Forms.LinkLabel link_logOut;
		private System.Windows.Forms.DataGridView dgv_data;
	}
}