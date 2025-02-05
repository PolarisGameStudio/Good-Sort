using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Falcon;

public class UDPNetworkManager
{


	private static UDPNetworkManager _instance;

	private const string Separator = ":";

	private IPAddress _serverIp;

	private IPEndPoint _hostEndPoint;

	private IPEndPoint _localIpPort;

	private UdpClient _client;

	private Thread _thread;

	public static UDPNetworkManager Instance => null;

	private UDPNetworkManager()
	{
	}

	public void Init()
	{
	}

	private IEnumerator ReceiveMessage()
	{
		return null;
	}

	public void Send(CSMessage message)
	{
	}
}
