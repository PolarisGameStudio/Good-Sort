using System;
using System.Collections.Generic;

namespace Falcon
{
	public class FClientManager
	{
		private static FClientManager instance;

		private IEnumerable<Type> scClasses;

		private Dictionary<string, Type> evt2Type;

		public static FClientManager Instance => null;

		private FClientManager()
		{
		}

		private void Init()
		{
		}

		public IEnumerable<Type> GetSCClasses()
		{
			return null;
		}

		public Type getEventType(string evt)
		{
			return null;
		}
	}
}
