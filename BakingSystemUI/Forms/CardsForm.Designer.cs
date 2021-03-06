﻿namespace BakingSystemUI.Forms
{
	partial class CardsForm
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
			this.txbx_type = new System.Windows.Forms.TextBox();
			this.txbx_duration = new System.Windows.Forms.TextBox();
			this.txbx_bank = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txbx_expDate = new System.Windows.Forms.TextBox();
			this.txbx_cvc = new System.Windows.Forms.TextBox();
			this.txbx_cardNumber = new System.Windows.Forms.TextBox();
			this.lbl_expDate = new System.Windows.Forms.Label();
			this.lbl_cvc = new System.Windows.Forms.Label();
			this.lbl_cardNumber = new System.Windows.Forms.Label();
			this.lbl_bank = new System.Windows.Forms.Label();
			this.dgv_cards = new System.Windows.Forms.DataGridView();
			this.txbx_balance = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.grbx_card.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).BeginInit();
			this.SuspendLayout();
			// 
			// grbx_card
			// 
			this.grbx_card.Controls.Add(this.txbx_balance);
			this.grbx_card.Controls.Add(this.label3);
			this.grbx_card.Controls.Add(this.txbx_type);
			this.grbx_card.Controls.Add(this.txbx_duration);
			this.grbx_card.Controls.Add(this.txbx_bank);
			this.grbx_card.Controls.Add(this.label2);
			this.grbx_card.Controls.Add(this.label1);
			this.grbx_card.Controls.Add(this.txbx_expDate);
			this.grbx_card.Controls.Add(this.txbx_cvc);
			this.grbx_card.Controls.Add(this.txbx_cardNumber);
			this.grbx_card.Controls.Add(this.lbl_expDate);
			this.grbx_card.Controls.Add(this.lbl_cvc);
			this.grbx_card.Controls.Add(this.lbl_cardNumber);
			this.grbx_card.Controls.Add(this.lbl_bank);
			this.grbx_card.Location = new System.Drawing.Point(544, 12);
			this.grbx_card.Name = "grbx_card";
			this.grbx_card.Size = new System.Drawing.Size(288, 259);
			this.grbx_card.TabIndex = 5;
			this.grbx_card.TabStop = false;
			this.grbx_card.Text = "Card";
			// 
			// txbx_type
			// 
			this.txbx_type.Enabled = false;
			this.txbx_type.Location = new System.Drawing.Point(97, 87);
			this.txbx_type.Name = "txbx_type";
			this.txbx_type.Size = new System.Drawing.Size(185, 20);
			this.txbx_type.TabIndex = 9;
			// 
			// txbx_duration
			// 
			this.txbx_duration.Enabled = false;
			this.txbx_duration.Location = new System.Drawing.Point(97, 55);
			this.txbx_duration.Name = "txbx_duration";
			this.txbx_duration.Size = new System.Drawing.Size(185, 20);
			this.txbx_duration.TabIndex = 8;
			// 
			// txbx_bank
			// 
			this.txbx_bank.Enabled = false;
			this.txbx_bank.Location = new System.Drawing.Point(97, 19);
			this.txbx_bank.Name = "txbx_bank";
			this.txbx_bank.Size = new System.Drawing.Size(185, 20);
			this.txbx_bank.TabIndex = 7;
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
			// dgv_cards
			// 
			this.dgv_cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_cards.Location = new System.Drawing.Point(0, 12);
			this.dgv_cards.Name = "dgv_cards";
			this.dgv_cards.Size = new System.Drawing.Size(538, 438);
			this.dgv_cards.TabIndex = 4;
			this.dgv_cards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cards_CellClick);
			// 
			// txbx_balance
			// 
			this.txbx_balance.Enabled = false;
			this.txbx_balance.Location = new System.Drawing.Point(97, 233);
			this.txbx_balance.Name = "txbx_balance";
			this.txbx_balance.Size = new System.Drawing.Size(185, 20);
			this.txbx_balance.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Balance:";
			// 
			// CardsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 450);
			this.Controls.Add(this.grbx_card);
			this.Controls.Add(this.dgv_cards);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CardsForm";
			this.Text = "CardsForm";
			this.Load += new System.EventHandler(this.CardsForm_Load);
			this.grbx_card.ResumeLayout(false);
			this.grbx_card.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_card;
		private System.Windows.Forms.TextBox txbx_type;
		private System.Windows.Forms.TextBox txbx_duration;
		private System.Windows.Forms.TextBox txbx_bank;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbx_expDate;
		private System.Windows.Forms.TextBox txbx_cvc;
		private System.Windows.Forms.TextBox txbx_cardNumber;
		private System.Windows.Forms.Label lbl_expDate;
		private System.Windows.Forms.Label lbl_cvc;
		private System.Windows.Forms.Label lbl_cardNumber;
		private System.Windows.Forms.Label lbl_bank;
		private System.Windows.Forms.DataGridView dgv_cards;
		private System.Windows.Forms.TextBox txbx_balance;
		private System.Windows.Forms.Label label3;
	}
}