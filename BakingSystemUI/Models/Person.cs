﻿using BakingSystemUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Models
{
	public class Person : Entity
	{
		private byte _age;
		public string Name { get; set; }
		public string Surname { get; set; }
		public byte Age { get { return _age; } set { _age = value > 0 && value < 90 ? value : (byte)0; } }
	}
}
