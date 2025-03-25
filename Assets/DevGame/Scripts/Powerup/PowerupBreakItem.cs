using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Spine.Unity;
using UnityEngine;

public class PowerupBreakItem : MonoBehaviour
{

	public Transform fx;

	public SkeletonAnimation anim;
	[SerializeField] float TimeAnim = 0;

	public void OnPlaySkillBreakItem(List<Item> listItem, Action callbackEnd)
	{
        UnityEngine.Debug.Log("Hammer_-4");
        int Count = listItem.Count;
		if(Count == 0)
		{
            callbackEnd?.Invoke();
            return;
		}	

		int index = 0;

		Action callback = () => {
			index++;
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
            item.OnRemoveDotCellTypeOneSlot();
        }
        UnityEngine.Debug.Log("Hammer_-5");
        StartCoroutine(StartAnim(callbackContinue));
        anim.AnimationState.SetAnimation(0, "animation", false);
    }

    IEnumerator StartAnim(Action callback)
	{
        UnityEngine.Debug.Log("Hammer_-6");

        yield return new WaitForSeconds(0.55f);
        fx.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(1f);
        callback?.Invoke();
        yield return new WaitForSeconds(0.35f);
		gameObject.SetActive(false);
        UnityEngine.Debug.Log("Hammer_-7");
    }
}
