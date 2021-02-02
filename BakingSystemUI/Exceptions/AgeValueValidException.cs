using System;
using System.Runtime.Serialization;

namespace BakingSystemUI.Validation
{
	[Serializable]
	internal class AgeValueValidException : Exception
	{
		public AgeValueValidException()
		{
		}

		public AgeValueValidException(string message) : base(message)
		{
		}

		public AgeValueValidException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected AgeValueValidException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}