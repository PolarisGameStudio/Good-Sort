using System;

namespace Crystal
{
	[Serializable]
	[Flags]
	public enum IgnoreArea
	{
		None = 0,
		Bot = 1,
		Top = 2,
		Left = 4,
		Right = 8,
		All = -1
	}
}
