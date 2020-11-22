using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Core
{
	static class Session
	{
		public static User User { get; set; }
		public static LogForm LogForm { get; set; }
	}
}
