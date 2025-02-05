using TMPro;
using UnityEngine;

public abstract class ShinyEffectTMP : MonoBehaviour
{
	[Header("PROPS")]
	public TextMeshProUGUI textMeshPro;

	[Header("RUNTIME PROPS")]
	[Tooltip("Tốc độ Shiny chaỵ qua từng chữ cái, không phụ thuộc vào độ dài của text.")]
	public float absoluteSpeed;

	[Tooltip("Thời gian delay giữa 2 lần Shiny xuất hiện")]
	public float interval;

	[Range(0f, 1f)]
	[Tooltip("Độ rộng của Shiny dựa trên tỉ lệ với Bounds của TextMeshPro")]
	public float width;

	[Space(5f)]
	[Tooltip("Sử dụng width dựa trên số lương ký tự thay vì tỷ lệ với Bounds của text")]
	public bool useCharactersWidthInstead;

	[Tooltip("Độ rộng của shiny tính theo số ký tự, nên đặt tối thiểu là 3")]
	public int charactersWidth;

	public AnimationCurve shinyCurve;

	public Color32 defaultColor;

	public Color32 shinyColor;

	public float Speed => 0f;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	protected abstract Color32 CalculateColor32(float positionValue);

	public void TurnOff()
	{
	}

	public void TurnOn()
	{
	}

	private bool CheckDuplicateShinyEffectOnGameObject()
	{
		return false;
	}

	private float Evaluate(float x)
	{
		return 0f;
	}

	private void GetTextMeshPro()
	{
	}
}
