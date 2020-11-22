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
		}
	}
}
