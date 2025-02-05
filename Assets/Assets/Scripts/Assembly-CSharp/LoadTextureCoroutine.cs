using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class LoadTextureCoroutine : MonoBehaviour
{
	public Coroutine currentCoroutine;

	public UnityWebRequest uwr;

	private void AbortDownload()
	{
	}

	private void StopCurrentCoroutine()
	{
	}

	public void ResetAndRunCoroutine(IEnumerator couroutine, UnityWebRequest uwr)
	{
	}

	public void StopPreLoading()
	{
	}
}
