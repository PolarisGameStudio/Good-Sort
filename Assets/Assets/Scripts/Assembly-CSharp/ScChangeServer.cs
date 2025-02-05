using Falcon;

public class ScChangeServer : SCMessage
{
	public string server_ip;

	public int server_tcp_port;

	public int server_udp_port;

	public string server_name;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
