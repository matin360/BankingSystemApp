using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Models;
using System;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
	public partial class ConfigureForm : Form
	{
		public ConfigureForm()
		{
			InitializeComponent();
			credentialsControl.btn_submit.Text = "Update";
			credentialsControl.btn_submit.Click += btn_updateUser;
			credentialsControl.txbx_email.Enabled = false;
		}

		private void btn_updateUser(object sender, EventArgs e)
		{
			UpdateUser(Session.User);
			MessageBox.Show("User updated!");
		}
		private void ConfigureForm_Load(object sender, EventArgs e)
		{
			GetCurrentUser(Session.User);
		}

		private void GetCurrentUser(User user)
		{
			txbx_age.Text = user.Age.ToString();
			txbx_name.Text = user.Name;
			txbx_surname.Text = user.Surname;
			credentialsControl.txbx_email.Text = user.Email;
			credentialsControl.txbx_password.Text = user.Password;
		}
		private void UpdateUser(User user)
		{
			user.Name = txbx_name.Text;
			user.Surname = txbx_surname.Text;
			user.Age = byte.Parse(txbx_age.Text);
			user.Email = credentialsControl.txbx_email.Text;
			user.Password = credentialsControl.txbx_password.Text;
			DbContext db = new DbContext();
			db.Users.Update(user);
		}
	}
}
