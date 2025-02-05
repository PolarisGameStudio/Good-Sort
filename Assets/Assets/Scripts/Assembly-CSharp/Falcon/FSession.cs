using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Falcon
{
	public class FSession : ISession
	{

		private FChannel channel;

		private List<ISessionListener> listeners;

		private string sessionId;

		private bool forceDisconnected;

		private Queue<FMessage> importantQueue;

		public FSession(FChannel channel)
		{
		}

		public FChannel GetChannel()
		{
			return null;
		}

		public List<ISessionListener> getListeners()
		{
			return null;
		}

		public string GetSessionId()
		{
			return null;
		}

		public bool IsActive()
		{
			return false;
		}

		public void OnChannelConnected()
		{
		}

		public void OnChannelDisconnected()
		{
		}

		public void OnMessage(FMessage message)
		{
		}

		public void Send(FMessage message)
		{
		}

		public void Send(FMessage message, bool important)
		{
		}

		public FFuture Send(FMessage message, FFuture future, int timeOut)
		{
			return null;
		}

		public FFuture Send(FMessage message, FFuture future)
		{
			return null;
		}

		public void SetTimeout(int sec)
		{
		}

		public void NewSession()
		{
		}

		public void Start()
		{
		}

		private IEnumerator Ping()
		{
			return null;
		}

		public void ContinueCurrentSession()
		{
		}

		public void AddListener(ISessionListener listener)
		{
		}

		public void RemoveListener(ISessionListener listener)
		{
		}

		public void RemoveAllListeners()
		{
		}

		public void Close()
		{
		}
	}
}
