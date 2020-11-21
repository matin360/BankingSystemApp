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
		public static DbSet<User> Users;
		public static DbSet<Card> Cards;

		public DbContext()
		{
			Users = new DbSet<User>();
			Cards = new DbSet<Card>();
		}
	}
}
