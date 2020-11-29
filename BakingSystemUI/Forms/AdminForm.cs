using BakingSystemUI.Core;
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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void link_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			Session.AdminForm = this;
			Session.LogForm.Show();
		}

		private void link_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AdminForm_Load(sender, e);
		}

		private void link_cards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			dgv_data.DataSource = Session.Data.Cards.GetAll()
						.Select(card => new { card.Id, card.CalrdHolder, card.CardNumber, card.CardType, card.Bank, card.CVC, card.ExpiredDate })
							.ToList();
		}

		private void link_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			dgv_data.DataSource = Session.Data.Users.GetAll()
				.Where(user => user.UserType == Roles.UserType.User)
					.Select(user => new { user.Id, FullName = $"{user.Name} {user.Surname}", user.Age, user.Email})
						.ToList();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}
	}
}
