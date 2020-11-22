using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Data
{
	public class DbSet<T>
	{
		private List<T> _list;
		public DbSet()
		{
			_list = new List<T>();
		}

		public void Add(T item)
		{
			_list.Add(item);
		}

		public void Remove(T item)
		{
			_list.Remove(item);
		}

		public void Update(T oldItem, T newItem)
		{
			_list.Remove(oldItem);
			_list.Add(newItem);
		}

		public IEnumerable<T> GetAll()
		{
			return _list;
		}

		public T FindItem(Func<T, bool> predicate)
		{
			T result = default(T);
			foreach (var item in _list)
			{
				if (predicate(item))
				{
					result = item;
				}
			}
			return result;
		}
	}
}
