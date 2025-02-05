namespace Falcon
{
	public interface IResponseListener
	{
		void OnResponse(CSSCResponse response);

		void OnTimeout();
	}
}
