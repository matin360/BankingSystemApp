using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Models
{
	public class Card
	{
		public int Id { get; set; }
		public BankName Bank { get; set; }
		public DurationType Duration { get; set; }
		public CardType CardType { get; set; }
		public string CardNumber { get; set; }
		public short CVC { get; set; }
		public DateTime ExpiredDate { get; set; }
		public string OwnerName { get; set; }
		public string OwnerId { get; set; }
	}
}
