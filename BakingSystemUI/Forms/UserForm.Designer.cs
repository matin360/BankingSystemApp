namespace BakingSystemUI.Forms
{
	partial class UserForm
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
			this.grbx_cards = new System.Windows.Forms.GroupBox();
			this.link_order = new System.Windows.Forms.LinkLabel();
			this.link_myCards = new System.Windows.Forms.LinkLabel();
			this.grbx_user = new System.Windows.Forms.GroupBox();
			this.lbl_age = new System.Windows.Forms.Label();
			this.lbl_surname = new System.Windows.Forms.Label();
			this.lbl_name = new System.Windows.Forms.Label();
			this.grbx_cards.SuspendLayout();
			this.grbx_user.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbx_cards
			// 
			this.grbx_cards.Controls.Add(this.link_order);
			this.grbx_cards.Controls.Add(this.link_myCards);
			this.grbx_cards.Location = new System.Drawing.Point(12, 162);
			this.grbx_cards.Name = "grbx_cards";
			this.grbx_cards.Size = new System.Drawing.Size(200, 127);
			this.grbx_cards.TabIndex = 3;
			this.grbx_cards.TabStop = false;
			this.grbx_cards.Text = "Cards";
			// 
			// link_order
			// 
			this.link_order.AutoSize = true;
			this.link_order.Location = new System.Drawing.Point(12, 58);
			this.link_order.Name = "link_order";
			this.link_order.Size = new System.Drawing.Size(63, 13);
			this.link_order.TabIndex = 1;
			this.link_order.TabStop = true;
			this.link_order.Text = "Order Cards";
			// 
			// link_myCards
			// 
			this.link_myCards.AutoSize = true;
			this.link_myCards.Location = new System.Drawing.Point(12, 31);
			this.link_myCards.Name = "link_myCards";
			this.link_myCards.Size = new System.Drawing.Size(51, 13);
			this.link_myCards.TabIndex = 0;
			this.link_myCards.TabStop = true;
			this.link_myCards.Text = "My Cards";
			// 
			// grbx_user
			// 
			this.grbx_user.Controls.Add(this.lbl_age);
			this.grbx_user.Controls.Add(this.lbl_surname);
			this.grbx_user.Controls.Add(this.lbl_name);
			this.grbx_user.Location = new System.Drawing.Point(12, 12);
			this.grbx_user.Name = "grbx_user";
			this.grbx_user.Size = new System.Drawing.Size(200, 127);
			this.grbx_user.TabIndex = 2;
			this.grbx_user.TabStop = false;
			this.grbx_user.Text = "User";
			// 
			// lbl_age
			// 
			this.lbl_age.AutoSize = true;
			this.lbl_age.Location = new System.Drawing.Point(12, 86);
			this.lbl_age.Name = "lbl_age";
			this.lbl_age.Size = new System.Drawing.Size(29, 13);
			this.lbl_age.TabIndex = 2;
			this.lbl_age.Text = "Age:";
			// 
			// lbl_surname
			// 
			this.lbl_surname.AutoSize = true;
			this.lbl_surname.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_surname.Location = new System.Drawing.Point(12, 59);
			this.lbl_surname.Name = "lbl_surname";
			this.lbl_surname.Size = new System.Drawing.Size(49, 13);
			this.lbl_surname.TabIndex = 1;
			this.lbl_surname.Text = "Surname";
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Location = new System.Drawing.Point(12, 27);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(38, 13);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Name:";
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 347);
			this.Controls.Add(this.grbx_cards);
			this.Controls.Add(this.grbx_user);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserForm";
			this.Text = "UserForm";
			this.grbx_cards.ResumeLayout(false);
			this.grbx_cards.PerformLayout();
			this.grbx_user.ResumeLayout(false);
			this.grbx_user.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_cards;
		private System.Windows.Forms.LinkLabel link_order;
		private System.Windows.Forms.LinkLabel link_myCards;
		private System.Windows.Forms.GroupBox grbx_user;
		private System.Windows.Forms.Label lbl_age;
		private System.Windows.Forms.Label lbl_surname;
		private System.Windows.Forms.Label lbl_name;
	}
}