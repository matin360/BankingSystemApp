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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void link_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new ConfigureForm().ShowDialog();
		}

		private void link_myCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new CardsForm().ShowDialog();
		}

		private void link_order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new CardManagerForm().ShowDialog();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Session.LogForm.Close();
		}

		private void link_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			Session.MainForm = this;
			Session.LogForm.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			User currentUser = Session.User;
			lbl_name.Text = $"Name: {currentUser.Name}";
			lbl_surname.Text = $"Surname: {currentUser.Surname}" ;
			lbl_age.Text = "Age: "+ currentUser.Age;
		}

		private void link_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm_Load(sender, e);
		}
	}
}
