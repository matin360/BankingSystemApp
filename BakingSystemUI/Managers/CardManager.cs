using BakingSystemUI.Core;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Managers
{
	public class CardManager
	{
		private readonly string _bankName;
		private readonly string _duration;
		private readonly string _cardType;
		private readonly Random _random;
		private readonly User _user;

		public CardManager(string bankName, string duration, string cardType, User user)
		{
			_bankName = bankName;
			_duration = duration;
			_cardType = cardType;
			_random = new Random();
			_user = user;
		}

		private string GetCardNumber()
		{
			StringBuilder cardNumber = new StringBuilder();
			
			for (int i = 0; i < 4; i++)
			{
				cardNumber.Append(_random.Next(1000, 9999));
			}
			return cardNumber.ToString();
		}

		private short GetCVC()
		{
			return (short)_random.Next(100, 999);
		}

		private DateTime GetExpireADate()
		{
			return DateTime.Now.AddYears(int.Parse(_duration));
		}

		private BankName GetBankName()
		{
			BankName bank = default;
			switch (_bankName)
			{
				case "Kapital Bank": bank = BankName.KapitalBank; break;
				case "Beynalxalq Bank": bank = BankName.BeynalxalqBank; break;
				case "BTB Bank": bank = BankName.BTBBank; break;
				case "Express Bank": bank = BankName.ExpressBank; break;
				case "Yellow Bank": bank = BankName.YellowBank; break;
			}
			return bank;
		}

		private CardType GetCardType()
		{
			CardType type = default;
			switch (_cardType)
			{
				case "Credit": type = CardType.Credit; break;
				case "Debet": type = CardType.Debet; break;
				case "Salary": type = CardType.Salary; break;
				case "Scolarship": type = CardType.Scolarship; break;
			}
			return type;
		}

		private DurationType GetDurationType()
		{
			DurationType duration = default;
			switch (int.Parse(_duration))
			{
				case (int)DurationType.OneYear : duration = DurationType.OneYear; break;
				case (int)DurationType.TwoYears: duration = DurationType.TwoYears; break;
				case (int)DurationType.FiveYears: duration = DurationType.FiveYears; break;
				case (int)DurationType.TenYears: duration = DurationType.TenYears; break;

			}
			return duration;
		}

		public Card GetCard()
		{
			return new Card
			{
				Id = Identificator<Card>.GetId(),
				Bank = GetBankName(),
				CVC = GetCVC(),
				Duration = GetDurationType(),
				ExpiredDate = GetExpireADate(),
				CardType = GetCardType(),
				CardNumber = GetCardNumber(),
				CalrdHolder = $"{_user.Name} {_user.Surname}",
				CardHolderId = _user.Id
			};
		}
	}
}
