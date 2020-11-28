using BakingSystemUI.Core;
using BakingSystemUI.Managers;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Data
{
	public class DbContext
	{
		public DbSet<User> Users;
		public DbSet<Card> Cards;

		public DbContext()
		{
			Users = new DbSet<User>();
			Cards = new DbSet<Card>();
			AddDefaultUsers();
			AddDefaultCards();
		}
		private List<User> defaultUsers = new List<User>
		{
			 new User { Id = Identificator<User>.GetId(), Email = "matin@gmail.com", Password = "1234567", UserType = Roles.UserType.User },
			new User { Id = Identificator<User>.GetId(), Name = "Ali", Surname = "Rahimzade", Age = 8, Email = "ali@gmail.com", Password = "1234567", UserType = Roles.UserType.User },
			new User { Id = Identificator<User>.GetId(), Email = "admin@gmail.com", Password = "1234567", UserType = Roles.UserType.Admin }
		};
		private void AddDefaultUsers()
		{
			Users.Add(defaultUsers[0]);
			Users.Add(defaultUsers[1]);
			Users.Add(defaultUsers[2]);
		}

		private void AddDefaultCards()
		{
			Cards.Add(new CardManager("Kapital Bank", "2", "Debet", defaultUsers[1]).GetCard());
			Cards.Add(new CardManager("BTB Bank", "1", "Salary", defaultUsers[0]).GetCard());
		}
	}
}
