using BakingSystemUI.Core;
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
			Users.Add(new User { Id = Identificator<User>.GetId(), Email = "matin@gmail.com", Password = "1234567"});
			Users.Add(new User { Id = Identificator<User>.GetId(), Email = "admin@gmail.com", Password = "1234567" });
		}


	}
}
