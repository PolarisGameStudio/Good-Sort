using System;

[Serializable]
public class ServerInfo
{
	public string server_ip;

	public int server_tcp_port;

	public int server_udp_port;

	public string server_name;

	public ServerInfo(string server_ip, int server_tcp_port, int server_udp_port, string server_name)
	{
	}
}
