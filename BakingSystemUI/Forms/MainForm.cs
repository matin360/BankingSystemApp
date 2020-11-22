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
	}
}
