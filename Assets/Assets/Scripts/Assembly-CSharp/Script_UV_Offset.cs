using System.Collections;
using UnityEngine;

public class Script_UV_Offset : MonoBehaviour
{
	public float speedX;

	public float speedY;

	public float tillingX;

	public float tillingY;

	private Renderer quadRenderer;

	private Vector2 offset;

	private Vector2 tilling;

	private bool runAdd = false;

	private void Awake()
	{
        quadRenderer = GetComponent<Renderer>();
		this.StartCoroutine(PlayCorotin());
    }

	private void FixedUpdate()
	{
		if(runAdd)
		{
            speedX -= Time.deltaTime;
		}
		else
		{
            speedX += Time.deltaTime;
        }

        if(speedX < 0)
		{
			runAdd = false;
        }	

		if(speedX >= 2)
		{
			runAdd = true;
        }

    }

	IEnumerator PlayCorotin()
	{
		while(true)
		{
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            quadRenderer.material.SetTextureScale("_MainTex", new Vector2(speedX, 1));
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();

        }
    }	

	private void OffSet()
	{
	}

	private void Tiling()
	{
	}
}
