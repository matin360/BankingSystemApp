using BakingSystemUI.Core;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BakingSystemUI.Roles;
using System.Configuration;
using BakingSystemUI.Data;

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
			using (DatabaseManager databaseManager = new DatabaseManager("myDB"))
			{
				dgv_data.DataSource = databaseManager.GetCards()
						.Select(card => new { card.Id, card.CalrdHolder, card.CardNumber, card.CardType, card.Bank, card.CVC, card.ExpiredDate })
							.ToList();
			}
		}

		private void link_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (DatabaseManager databaseManager = new DatabaseManager("myDB"))
			{
				dgv_data.DataSource = databaseManager.GetUsers().Where(u => u.UserType == UserType.User).ToList();
			}
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}
	}
}
