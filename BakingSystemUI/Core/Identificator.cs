using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Core
{
	public static class Identificator<T>
	{
		private static int _counter;

		static Identificator()
		{
			_counter = 0;
		}
		public static int GetId()
		{
			_counter++;
			return _counter;
		}
	}
}
