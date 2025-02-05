using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Starts
{
	public class FileGetRequest : StartAction
	{
		private readonly string destination;

		private readonly string url;

		private Exception exception;

		private bool isDone;

		public int progress;

		public override Exception Exception => null;

		public override bool Done => false;

		public FileGetRequest(string url, string destination)
		{
		}

		public override void Invoke()
		{
		}
	}
}
