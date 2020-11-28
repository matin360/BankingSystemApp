using BakingSystemUI.Core;
using BakingSystemUI.Managers;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
	public partial class CardManagerForm : Form
	{
		public CardManagerForm()
		{
			InitializeComponent();
		}

		private void btn_order_Click(object sender, EventArgs e)
		{
			string
				bankName = cmbx_bank.Text,
				duration = cmbx_duratoin.Text,
				cardType = cmbx_type.Text;

			// validation

			CardManager cardManager = new CardManager(bankName, duration, cardType, Session.User);
			Card card = cardManager.GetCard();

			txbx_cardNumber.Text = card.CardNumber;
			txbx_cvc.Text = card.CVC.ToString();
			txbx_expDate.Text = card.ExpiredDate.ToString();
			MessageBox.Show("Card is done!");
		}
	}
}
