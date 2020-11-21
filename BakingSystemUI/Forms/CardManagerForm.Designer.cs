namespace BakingSystemUI.Forms
{
	partial class CardManagerForm
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
			this.grbx_card = new System.Windows.Forms.GroupBox();
			this.btn_order = new System.Windows.Forms.Button();
			this.cmbx_duratoin = new System.Windows.Forms.ComboBox();
			this.cmbx_type = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txbx_expDate = new System.Windows.Forms.TextBox();
			this.txbx_cvc = new System.Windows.Forms.TextBox();
			this.txbx_cardNumber = new System.Windows.Forms.TextBox();
			this.cmbx_bank = new System.Windows.Forms.ComboBox();
			this.lbl_expDate = new System.Windows.Forms.Label();
			this.lbl_cvc = new System.Windows.Forms.Label();
			this.lbl_cardNumber = new System.Windows.Forms.Label();
			this.lbl_bank = new System.Windows.Forms.Label();
			this.grbx_card.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbx_card
			// 
			this.grbx_card.Controls.Add(this.btn_order);
			this.grbx_card.Controls.Add(this.cmbx_duratoin);
			this.grbx_card.Controls.Add(this.cmbx_type);
			this.grbx_card.Controls.Add(this.label2);
			this.grbx_card.Controls.Add(this.label1);
			this.grbx_card.Controls.Add(this.txbx_expDate);
			this.grbx_card.Controls.Add(this.txbx_cvc);
			this.grbx_card.Controls.Add(this.txbx_cardNumber);
			this.grbx_card.Controls.Add(this.cmbx_bank);
			this.grbx_card.Controls.Add(this.lbl_expDate);
			this.grbx_card.Controls.Add(this.lbl_cvc);
			this.grbx_card.Controls.Add(this.lbl_cardNumber);
			this.grbx_card.Controls.Add(this.lbl_bank);
			this.grbx_card.Location = new System.Drawing.Point(22, 23);
			this.grbx_card.Name = "grbx_card";
			this.grbx_card.Size = new System.Drawing.Size(288, 271);
			this.grbx_card.TabIndex = 3;
			this.grbx_card.TabStop = false;
			this.grbx_card.Text = "Card";
			// 
			// btn_order
			// 
			this.btn_order.Location = new System.Drawing.Point(97, 232);
			this.btn_order.Name = "btn_order";
			this.btn_order.Size = new System.Drawing.Size(185, 33);
			this.btn_order.TabIndex = 3;
			this.btn_order.Text = "Order";
			this.btn_order.UseVisualStyleBackColor = true;
			// 
			// cmbx_duratoin
			// 
			this.cmbx_duratoin.FormattingEnabled = true;
			this.cmbx_duratoin.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
			this.cmbx_duratoin.Location = new System.Drawing.Point(97, 54);
			this.cmbx_duratoin.Name = "cmbx_duratoin";
			this.cmbx_duratoin.Size = new System.Drawing.Size(185, 21);
			this.cmbx_duratoin.TabIndex = 9;
			// 
			// cmbx_type
			// 
			this.cmbx_type.FormattingEnabled = true;
			this.cmbx_type.Items.AddRange(new object[] {
            "Salary",
            "Debet",
            "Scolarship",
            "Credit"});
			this.cmbx_type.Location = new System.Drawing.Point(97, 86);
			this.cmbx_type.Name = "cmbx_type";
			this.cmbx_type.Size = new System.Drawing.Size(185, 21);
			this.cmbx_type.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(12, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Duration:";
			// 
			// txbx_expDate
			// 
			this.txbx_expDate.Enabled = false;
			this.txbx_expDate.Location = new System.Drawing.Point(97, 194);
			this.txbx_expDate.Name = "txbx_expDate";
			this.txbx_expDate.Size = new System.Drawing.Size(185, 20);
			this.txbx_expDate.TabIndex = 5;
			// 
			// txbx_cvc
			// 
			this.txbx_cvc.Enabled = false;
			this.txbx_cvc.Location = new System.Drawing.Point(97, 155);
			this.txbx_cvc.Name = "txbx_cvc";
			this.txbx_cvc.Size = new System.Drawing.Size(185, 20);
			this.txbx_cvc.TabIndex = 4;
			// 
			// txbx_cardNumber
			// 
			this.txbx_cardNumber.Enabled = false;
			this.txbx_cardNumber.Location = new System.Drawing.Point(97, 119);
			this.txbx_cardNumber.Name = "txbx_cardNumber";
			this.txbx_cardNumber.Size = new System.Drawing.Size(185, 20);
			this.txbx_cardNumber.TabIndex = 3;
			// 
			// cmbx_bank
			// 
			this.cmbx_bank.FormattingEnabled = true;
			this.cmbx_bank.Items.AddRange(new object[] {
            "Kapital Bank",
            "Express Bank",
            "BTB Bank",
            "Yellow Bank",
            "Beynalxalq Bank"});
			this.cmbx_bank.Location = new System.Drawing.Point(97, 24);
			this.cmbx_bank.Name = "cmbx_bank";
			this.cmbx_bank.Size = new System.Drawing.Size(185, 21);
			this.cmbx_bank.TabIndex = 3;
			// 
			// lbl_expDate
			// 
			this.lbl_expDate.AutoSize = true;
			this.lbl_expDate.Location = new System.Drawing.Point(12, 194);
			this.lbl_expDate.Name = "lbl_expDate";
			this.lbl_expDate.Size = new System.Drawing.Size(71, 13);
			this.lbl_expDate.TabIndex = 3;
			this.lbl_expDate.Text = "Expired Date:";
			// 
			// lbl_cvc
			// 
			this.lbl_cvc.AutoSize = true;
			this.lbl_cvc.Location = new System.Drawing.Point(12, 162);
			this.lbl_cvc.Name = "lbl_cvc";
			this.lbl_cvc.Size = new System.Drawing.Size(31, 13);
			this.lbl_cvc.TabIndex = 2;
			this.lbl_cvc.Text = "CVC:";
			// 
			// lbl_cardNumber
			// 
			this.lbl_cardNumber.AutoSize = true;
			this.lbl_cardNumber.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_cardNumber.Location = new System.Drawing.Point(12, 126);
			this.lbl_cardNumber.Name = "lbl_cardNumber";
			this.lbl_cardNumber.Size = new System.Drawing.Size(47, 13);
			this.lbl_cardNumber.TabIndex = 1;
			this.lbl_cardNumber.Text = "Number:";
			// 
			// lbl_bank
			// 
			this.lbl_bank.AutoSize = true;
			this.lbl_bank.Location = new System.Drawing.Point(12, 27);
			this.lbl_bank.Name = "lbl_bank";
			this.lbl_bank.Size = new System.Drawing.Size(35, 13);
			this.lbl_bank.TabIndex = 0;
			this.lbl_bank.Text = "Bank:";
			// 
			// CardManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 326);
			this.Controls.Add(this.grbx_card);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CardManagerForm";
			this.Text = "CardManagerForm";
			this.grbx_card.ResumeLayout(false);
			this.grbx_card.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_card;
		private System.Windows.Forms.Button btn_order;
		private System.Windows.Forms.ComboBox cmbx_duratoin;
		private System.Windows.Forms.ComboBox cmbx_type;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbx_expDate;
		private System.Windows.Forms.TextBox txbx_cvc;
		private System.Windows.Forms.TextBox txbx_cardNumber;
		private System.Windows.Forms.ComboBox cmbx_bank;
		private System.Windows.Forms.Label lbl_expDate;
		private System.Windows.Forms.Label lbl_cvc;
		private System.Windows.Forms.Label lbl_cardNumber;
		private System.Windows.Forms.Label lbl_bank;
	}
}