using BakingSystemUI.Forms;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Windows.Forms;

namespace BakingSystemUI
{
	public partial class LogForm : Form
	{
		public LogForm()
		{
			InitializeComponent();
			regControl.btn_submit.Text = "Register";
			logControl.btn_submit.Text = "Login";
			regControl.btn_submit.Click += btn_register_clicked;
			logControl.btn_submit.Click += btn_login_clicked;
		}

		private void btn_login_clicked(object sender, EventArgs e)
		{
			// get data
			// validate data
			// check data - database
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
			User user = new User { Email = email, Password = password, UserType = UserType.User };
			MessageBox.Show("You successfully registered!");
		}
	}

}
