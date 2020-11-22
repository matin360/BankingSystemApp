using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Forms;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Windows.Forms;

namespace BakingSystemUI
{
	public partial class LogForm : Form
	{
		private readonly DbContext dbContext;
		public LogForm()
		{
			InitializeComponent();
			regControl.btn_submit.Text = "Register";
			logControl.btn_submit.Text = "Login";
			regControl.btn_submit.Click += btn_register_clicked;
			logControl.btn_submit.Click += btn_login_clicked;
			dbContext = new DbContext();
		}

		private void btn_login_clicked(object sender, EventArgs e)
		{
			// get data
			string
				email = logControl.txbx_email.Text,
				password = regControl.txbx_password.Text;
			// validate data

			// check data - database
			User currentUser = dbContext.Users.FindItem(u => u.Email == email);
			if (currentUser != null)
			{
				Session.User = currentUser;
				Session.LogForm = this;
				MessageBox.Show("You successfully logged in!");
				new MainForm().Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Email or password is wrong!");
			}
			// go to new form or XXX
		}

		private void btn_register_clicked(object sender, EventArgs e)
		{
			// get data
			string
				email = regControl.txbx_email.Text,
				password = regControl.txbx_password.Text;
			// validate data

			// register
			if(dbContext.Users.FindItem(u => u.Email == email) == null)
			{
				User user = new User { Email = email, Password = password, UserType = UserType.User };
				dbContext.Users.Add(user);
				MessageBox.Show("You successfully registered!");
			}
			else
			{
				MessageBox.Show("This user already exists!");
			}
		}
	}

}
