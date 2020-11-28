using BakingSystemUI.Core;
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
	public partial class CardsForm : Form
	{
		public CardsForm()
		{
			InitializeComponent();
		}

		private void CardsForm_Load(object sender, EventArgs e)
		{
			// get all cards by User's Id
			dgv_cards.DataSource = Session.Data.Cards.GetAllBy(card => card.CardHolderId == Session.User.Id)
									.Select(card => new { card.Id, card.CalrdHolder, card.CardNumber, card.CardType, card.Bank, card.CVC, card.ExpiredDate })
										.ToList();
		}

		private void dgv_cards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var dgv = sender as DataGridView;
			
			int idColumn = default;
			if (int.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out idColumn))
			{
				Card card = Session.Data.Cards.FindItem(c => c.Id == idColumn);

				txbx_bank.Text = card.Bank.ToString();
				txbx_cardNumber.Text = card.CardNumber.ToString();
				txbx_cvc.Text = card.CVC.ToString();
				txbx_duration.Text = card.Duration.ToString();
				txbx_expDate.Text = card.ExpiredDate.ToString();
				txbx_type.Text = card.CardType.ToString();
			}
		}
	}
}
