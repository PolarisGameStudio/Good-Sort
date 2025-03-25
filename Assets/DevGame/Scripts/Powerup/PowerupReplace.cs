using Coffee.UIExtensions;
using DG.Tweening;

using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PowerupReplace : MonoBehaviour
{

	public Transform container;

	[SerializeField]
	private MagicWard _magicWard;

	[SerializeField]
	private SkeletonAnimation _spineWand;

	[SerializeField]
	private Transform _fxWand;

	[SerializeField]
	private ParticleSystem _fxBurst;

	public void Active(List<Item> listCell, Action<ItemAsset, Vector3> callback)
	{
        Debug.Log("Replay_-2");
        StartCoroutine(PlayAnimation(listCell, callback));
	}


	IEnumerator PlayAnimation(List<Item> listCell, Action<ItemAsset, Vector3> callback)
	{
        Audio.Play(ScStatic.SFX_Ingame_UsePowerUp);
        Debug.Log("Replay_-3");
        var itemAsset = SOItemContainer.Instance.GetItemAsset(listCell[0].ItemType);
		var localScale = listCell[0].transform.localScale;

        List<MagicWard> objWiza = new();
		_spineWand.AnimationState.SetAnimation(0, "Start", false);
		float time = 1.2f;

		float time1 = 0.6f;
        yield return new WaitForSeconds(time1);
        Vibration.Vibrate(100);
        Audio.Play(ScStatic.SFX_Ingame_PowerUp_MagicWard);
        yield return new WaitForSeconds(time - time1);
        _spineWand.AnimationState.SetAnimation(0, "Start_Idle", false);
        foreach (var cel in listCell)
        {
            var item = Instantiate(_magicWard, null);
            item.SetPos(_fxWand.transform.position, cel.transform.position + new Vector3(0, 0.5f, 0));
			cel.OnMoveWhenEndDrag(cel.transform.localPosition + new Vector3(0, -0.5f, 0), false, null, 0, 0.25f);
			cel.SetMaxOrderLayerForSprite();
            objWiza.Add(item);
        }
		yield return new WaitForEndOfFrame();
        time = 1.067f;
        _fxWand.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);

        _spineWand.AnimationState.SetAnimation(0, "Stop", false);
        time = 0.5f;

		List<ItemContainer> itemContainers = new();

        foreach (var cel in listCell)
        {
			itemContainers.Add(cel.itemContainer);
            cel.OnMoveWhenEndDrag(cel.transform.localPosition + new Vector3(0, 0.5f, 0), false, () =>
			{
				cel.UpdateScaleCurrent(localScale);
                cel.SetNewItemAsset(itemAsset);
				cel.ResetMaxOrderLayerForSprite();
			}, 0, 0.25f);
        }

		var newItemContainers =  itemContainers.Distinct().ToList();

        yield return new WaitForSeconds(time);

		foreach(var it in newItemContainers)
		{
			it.OnCheckSucessItem();
        }

		foreach(var it in objWiza)
		{
			Destroy(it.gameObject);
		}	

        foreach (var cel in listCell)
		{
			var anim = Instantiate(_fxBurst, cel.transform);
            anim.transform.localPosition = new Vector3(0, 0.5f, 0);
        }

		callback?.Invoke(itemAsset, localScale);
        _fxWand.gameObject.SetActive(false);
        transform.gameObject.SetActive(false);
    }

}
