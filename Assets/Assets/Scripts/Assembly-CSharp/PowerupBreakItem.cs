using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerupBreakItem : MonoBehaviour
{

	public Transform fx;

	public SkeletonAnimation anim;
	[SerializeField] float TimeAnim = 0;
	private bool isContinue = false;

	public void OnPlaySkillBreakItem(List<Item> listItem, Action callbackEnd)
	{
		isContinue = false;

        int Count = listItem.Count;
		if(Count == 0)
		{
            callbackEnd?.Invoke();
            return;
		}	

		int index = 0;

		Action callback = () => {
			index++;
            if (index == Count)
            {
				isContinue = true;
            }
        };

		Action callbackContinue = () => {
            foreach (Item item in listItem)
            {
                Destroy(item.gameObject);
            }
            callbackEnd?.Invoke();

        };

		foreach (var item in listItem)
		{
			item.transform.parent = null;
			item.itemContainer.RemoveIndexItemInLayerItem(item);
            item.OnStartMoveSkillSwap(Vector3.zero, callback, 0.5f);
        }

		StartCoroutine(StartAnim(callbackContinue));
        anim.AnimationState.SetAnimation(0, "animation", false);
    }

    IEnumerator StartAnim(Action callback)
	{
        yield return new WaitForSeconds(0.55f);
        fx.GetComponent<ParticleSystem>().Play();
		yield return new WaitForSeconds(1f);
        callback?.Invoke();
        yield return new WaitForSeconds(0.35f);
		gameObject.SetActive(false);
    }

    private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
