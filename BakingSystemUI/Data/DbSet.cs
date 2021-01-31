using BakingSystemUI.Core;
using System;
using System.Collections.Generic;

namespace BakingSystemUI.Data
{
	public class DbSet<T> where T : Entity
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

		public void Update(T item)
		{
			var oldItem = _list.Find(i => i.Id == item.Id);
			if (oldItem != null)
			{
				_list.Remove(oldItem);
				_list.Add(item);
			}
		}

		public IEnumerable<T> GetAll()
		{
			return _list;
		}

		public IEnumerable<T> GetAllBy(Func<T, bool> predicate)
		{
			foreach (var item in _list)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
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
