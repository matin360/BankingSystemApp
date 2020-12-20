using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;

namespace BakingSystemUI.Data
{
	public class DatabaseManager : IDisposable
	{
		private readonly SqlConnection _sqlConn;

		public DatabaseManager(string connectionName)
		{
			string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			_sqlConn = new SqlConnection(connectionString);
			_sqlConn.Open();
		}

		public void Dispose()
		{
			_sqlConn.Dispose();
		}

		private int IUD_command(string query, Action<SqlCommand> action)
		{
			int affectedRows = default;
			using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConn))
			{
				action(sqlCommand);
				affectedRows = sqlCommand.ExecuteNonQuery();
			}
			return affectedRows;
		}

		public int AddCard(Card card)
		{
			return IUD_command("INSERT INTO Cards(Number, CVC, Bank, Type, Duration, CardHolder, ExpireDate, Balance, UserId) VALUES(@n, @cvc, @b, @t, @d, @ch, @ed, @bl, @uid)", com =>
			{
				com.Parameters.AddWithValue("@n", card.CardNumber);
				com.Parameters.AddWithValue("@cvc", card.CVC);
				com.Parameters.AddWithValue("@b", card.Bank.ToString());
				com.Parameters.AddWithValue("@t", card.CardType.ToString());
				com.Parameters.AddWithValue("@d", card.Duration);
				com.Parameters.AddWithValue("@ch", card.CalrdHolder);
				com.Parameters.AddWithValue("@ed", card.ExpiredDate);
				com.Parameters.AddWithValue("@bl", card.Balance);
				com.Parameters.AddWithValue("@uid", card.CardHolderId);
			});
		}
		public int AddUser(User user)
		{
			return IUD_command("INSERT INTO Users(Name, Surname, Age, Email, Password, UserType) VALUES(@n, @s, @a, @e, @ps, @ut)", sqlCommand => {
				 sqlCommand.Parameters.AddWithValue("@n", user.Name);
				 sqlCommand.Parameters.AddWithValue("@s", user.Surname);
				 sqlCommand.Parameters.AddWithValue("@a", user.Age);
				 sqlCommand.Parameters.AddWithValue("@e", user.Email);
				 sqlCommand.Parameters.AddWithValue("@ps", user.Password);
				 sqlCommand.Parameters.AddWithValue("@ut", user.UserType.ToString());
			 });
		}

		public int UpdateUser(User user)
		{
			return IUD_command("UPDATE Users SET Name=@n, Surname=@s, Age=@a, Password=@ps WHERE Id=@id", sqlCommand => {
				sqlCommand.Parameters.AddWithValue("@n", user.Name);
				sqlCommand.Parameters.AddWithValue("@s", user.Surname);
				sqlCommand.Parameters.AddWithValue("@a", user.Age);
				sqlCommand.Parameters.AddWithValue("@ps", user.Password);
				sqlCommand.Parameters.AddWithValue("@id", user.Id);
			});
		}

		public int DeleteUser(User user)
		{
			return IUD_command("DELETE Users WHERE Id=@id", sqlCommand => {
				sqlCommand.Parameters.AddWithValue("@id", user.Id);
			});
		}

		private IEnumerable<Card> _GetCards(string query, Action<SqlCommand> action)
		{
			List<Card> items = new List<Card>(); // response from server
			using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConn))
			{
				action(sqlCommand);
				using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
				{
					while (dataReader.Read())
					{
						items.Add(new Card
						{
							Id = Convert.ToInt32(dataReader["Id"]),
							Bank = (BankName)Enum.Parse(typeof(BankName), dataReader["Bank"].ToString()),
							CVC = Convert.ToInt16(dataReader["CVC"]),
							ExpiredDate = (DateTime)dataReader["ExpireDate"],
							Duration = (DurationType)Enum.Parse(typeof(DurationType), dataReader["Duration"].ToString()),
							CardType = (CardType)Enum.Parse(typeof(CardType), dataReader["Type"].ToString()),
							CardNumber = dataReader["Number"].ToString(),
							CalrdHolder = dataReader["CardHolder"].ToString(),
							CardHolderId = Convert.ToInt32(dataReader["UserId"]),
							Balance = Convert.ToDecimal(dataReader["Balance"])
						});
					}
				}
			}
			return items;
		}
		public IEnumerable<Card> GetCards()
		{
			return _GetCards("SELECT Id, Number, CVC, Bank, Type, CardHolder, ExpireDate, Duration, Balance, UserId FROM Cards", (com) => { });
		}

		public IEnumerable<Card> GetCardsById(int idColumn)
		{
			return _GetCards("SELECT Id, Number, CVC, Bank, Type, CardHolder, ExpireDate, Balance, Duration, UserId FROM Cards WHERE Id=@id", (com) => {
				com.Parameters.AddWithValue("@id", idColumn);
			});
		}

		public IEnumerable<Card> GetCardsByUserId(int id)
		{
			return _GetCards("SELECT Id, Number, CVC, Bank, Type, CardHolder, ExpireDate, Balance, Duration, UserId FROM Cards WHERE UserId=@id", (com) => {
				com.Parameters.AddWithValue("@id", id);
			});
		}

		private IEnumerable<User> _GetUsers(string query, Action<SqlCommand> action)
		{
			List<User> users = new List<User>(); // response from server
			using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConn))
			{
				action(sqlCommand);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
				{
					while (sqlDataReader.Read())
					{
						users.Add(new User
						{
							Id = Convert.ToInt32(sqlDataReader["Id"]),
							Name = sqlDataReader["Name"].ToString(),
							Surname = sqlDataReader["Surname"].ToString(),
							Age = Convert.ToByte(sqlDataReader["Age"]),
							Email = sqlDataReader["Email"].ToString(),
							Password = sqlDataReader["Password"].ToString(),
							UserType = (UserType)Enum.Parse(typeof(UserType), sqlDataReader["UserType"].ToString())
						});
					}
				}
			}
			return users;
		}

		public IEnumerable<User> GetUsers()
		{
			return _GetUsers("SELECT Id, Name, Surname, Age, Email, Password, UserType FROM Users", com => { });
		}

		// homework: GetCards, AddCard, DeleteCard, GetCardById
	}
}
