using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Validation
{
	public class Validator
	{
        public void Validate(params string[] txbxs)
        {
            foreach (string txbx in txbxs)
            {
                if (string.IsNullOrEmpty(txbx))
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public byte IsAgeValueValid(string age, sbyte limit)
        {
            if (string.IsNullOrEmpty(age))
            {
                throw new ArgumentNullException("Age field is empty!");
            }
            if (!byte.TryParse(age, out byte result))
            {
                throw new FormatException();
            }
            if (byte.Parse(age) < limit)
            {
                throw new AgeValueValidException();
            }
            return result;
        }

        public void IsEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("Email field is empty!");
            }

            if (!email.Contains("@"))
            {
                throw new InvalidEmailException("Email must contains at(@)");
            }
        }

        public void IsPasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException();
            if (password.Length < 4)
                throw new Models.InvalidPasswordException("Length of password must contains 4 or more characters");

        }
    }
}
