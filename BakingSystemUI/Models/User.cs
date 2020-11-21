using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Models
{
	public class User : Person
	{
		private string _email;
		private string _password;
		public string Email { get { return _email; } set { _email = value.Contains("@") ? value : string.Empty; } }
		public string Password { 
			get { return _password; } 
			set 
			{
				if (value.Length >= 6)
					_password = value;
				else
					throw new InvalidPasswordException("Password includes not enough characters!");
			} 
		}
	}
}
