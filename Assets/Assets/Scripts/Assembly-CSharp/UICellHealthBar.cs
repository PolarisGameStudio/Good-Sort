using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICellHealthBar : MonoBehaviour
{
	public Image[] dots;

	public TextMeshProUGUI txtHealth;

	public ItemContainer itemContainer;

	private int current;

	private void Start()
	{

	}

	public void Init(int max)
	{
        txtHealth.text = max.ToString();
		current = max;
		for(int i = 0; i < max; i++)
		{
			dots[i].gameObject.SetActive(true);

        }
    }

	public void RemoveDot()
	{
		if(current - 1 < 0)
		{
            txtHealth.text = "0";
            return;
		}
		dots[current - 1].enabled = false;
		current--;
        txtHealth.text = current.ToString();
    }

    private void Change(int remain)
	{
	}
}
