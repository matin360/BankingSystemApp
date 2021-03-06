﻿using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Forms;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using BakingSystemUI;
using BakingSystemUI.Validation;

namespace BakingSystemUI
{
	public partial class LogForm : Form
	{
		private List<User> users;
		private Validation.Validator validator;
		public LogForm()
		{
			InitializeComponent();
			regControl.btn_submit.Text = "Register";
			logControl.btn_submit.Text = "Login";
			regControl.btn_submit.Click += btn_register_clicked;
			logControl.btn_submit.Click += btn_login_clicked;
			validator = new Validation.Validator();
		}

		private void btn_login_clicked(object sender, EventArgs e)
		{
			try
			{
				// get data
				string
				email = logControl.txbx_email.Text,
				password = logControl.txbx_password.Text;
				// validate data
			
				validator.IsEmailValid(email);
				validator.IsPasswordValid(password);
			


				// check data - database
				using (DatabaseManager db = new DatabaseManager("myDB"))
				{
					users = (List<User>)db.GetUsers();
				}
				User currentUser = users.Find(user => user.Email == email && user.Password == password);
				if (currentUser != null)
				{
					Session.User = currentUser;
					Session.LogForm = this;
					if (currentUser.UserType == UserType.User)
					{
						new MainForm().Show();
						Hide();
					}
					else if (currentUser.UserType == UserType.Admin)
					{
						new AdminForm().Show();
						Hide();
					}
				}
				else
				{
					MessageBox.Show("Email or password is wrong!");
				}
			}
			catch (InvalidEmailException exp)
			{
				MessageBox.Show(exp.Message);
			}
			catch (InvalidPasswordException exp)
			{
				MessageBox.Show(exp.Message);
			}
			// go to new form
		}

		private void btn_register_clicked(object sender, EventArgs e)
		{
			try
			{
				// get data
				string
				email = regControl.txbx_email.Text,
				password = regControl.txbx_password.Text;
				// validate data
			
				validator.IsEmailValid(email);
				validator.IsPasswordValid(password);



				using (DatabaseManager db = new DatabaseManager("myDB"))
				{
					users = (List<User>)db.GetUsers();
				}
				// register
				if (!users.Any(u => u.Email == email))
				{
					int aRows = default;
					User user = new User { Name = string.Empty, Surname = string.Empty, Age = default, Email = email, Password = password, UserType = UserType.User };
					using (DatabaseManager db = new DatabaseManager("myDB"))
					{
						aRows = db.AddUser(user);
					}

					if (aRows > 0)
					{
						MessageBox.Show("You successfully registered!");
					}
					else
					{
						MessageBox.Show("Registration failed!");
					}
				}
				else
				{
					MessageBox.Show("This user already exists!");
				}
			}
			catch (InvalidEmailException exp)
			{
				MessageBox.Show(exp.Message);
			}
			catch (InvalidPasswordException exp)
			{
				MessageBox.Show(exp.Message);
			}
		}

		private void regControl_Load(object sender, EventArgs e)
		{

		}
	}

}
