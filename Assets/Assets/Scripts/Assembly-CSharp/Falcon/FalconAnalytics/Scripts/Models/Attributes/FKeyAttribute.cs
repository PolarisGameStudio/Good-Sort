using System;

namespace Falcon.FalconAnalytics.Scripts.Models.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class FKeyAttribute : Attribute
	{
		public bool Ignore { get; set; }

		public string Name { get; set; }

		public bool RemoveIfNull { get; set; }
	}
}
