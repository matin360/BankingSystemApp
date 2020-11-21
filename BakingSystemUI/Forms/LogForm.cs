using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			
		}

		private void btn_register_clicked(object sender, EventArgs e)
		{
			
		}
	}

}
