using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;

public class UISkeGraphicSequenceAnimation : MonoBehaviour
{
	[Serializable]
	public class Sequence
	{
		public bool loop;

		[SpineAnimation(null, null, true, false, dataField = "ske")]
		public string anim;
	}

	[Serializable]
	public class Complete
	{
		public float delay;

		public UnityEvent action;
	}

	[Header("Skeleton Graphic")]
	public SkeletonGraphic ske;

	[Header("Animation")]
	[SpineAnimation(null, null, true, false, dataField = "ske")]
	public string start;

	public Sequence[] sequences;

	[Header("Events")]
	public UnityEvent play;

	public Complete complete;

	private void OnEnable()
	{
	}

	public void ChangeTimeScale(float max, float duration = 0.25f)
	{
	}

	public void InitSkeleton()
	{
	}
}
