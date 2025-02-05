using System;
using UnityEngine.Scripting;

namespace Falcon.FalconCore.Scripts.Repositories.News
{
	[Serializable]
	public class InAppData
	{
		public int count;

		public string isoCurrencyCode;

		public decimal max;

		public decimal total;

		[Preserve]
		public InAppData()
		{
		}

		public InAppData(decimal total, decimal max, int count, string isoCurrencyCode)
		{
		}

		public void Update(decimal amount)
		{
		}
	}
}
