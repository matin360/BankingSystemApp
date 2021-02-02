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
			int aRows = UpdateUser(Session.User);
			if (aRows > 0)
				MessageBox.Show("User updated!");
			else
				MessageBox.Show("Update failed!");
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
		private int UpdateUser(User user)
		{
			int affectedRows = 0;
			user.Name = txbx_name.Text;
			user.Surname = txbx_surname.Text;
			user.Age = new Validation.Validator().IsAgeValueValid(txbx_age.Text, 0);
			user.Email = credentialsControl.txbx_email.Text;
			user.Password = credentialsControl.txbx_password.Text;

			// validate data: homework

			using(DatabaseManager db = new DatabaseManager("myDB"))
			{
				affectedRows = db.UpdateUser(user);
			}

			return affectedRows;
		}
	}
}
