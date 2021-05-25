public class AdvChatWindowOnOff : MonoBehaviour // TypeDefIndex: 8410
{
	// Fields
	[SerializeField] // RVA: 0x16F4D0 Offset: 0x16F5D1 VA: 0x16F4D0
	private float MoveTime; // 0x18
	[SerializeField] // RVA: 0x16F4E0 Offset: 0x16F5E1 VA: 0x16F4E0
	private Vector2 StartPos; // 0x1C
	private bool isOpen; // 0x24
	[SerializeField] // RVA: 0x16F4F0 Offset: 0x16F5F1 VA: 0x16F4F0
	private RectTransform MoveRect; // 0x28
	private float nTime; // 0x30
	[SerializeField] // RVA: 0x16F500 Offset: 0x16F601 VA: 0x16F500
	private CanvasGroup canvasGroup; // 0x38
	[SerializeField] // RVA: 0x16F510 Offset: 0x16F611 VA: 0x16F510
	private AnimationCurve slideCurve; // 0x40
	[SerializeField] // RVA: 0x16F520 Offset: 0x16F621 VA: 0x16F520
	private AnimationCurve fadeCurve; // 0x48
	private float curveSpeed; // 0x50
	private float curveRate; // 0x54

	// Methods

	// RVA: 0x1BF9710 Offset: 0x1BF9811 VA: 0x1BF9710
	public void DoOpen() { }

	// RVA: 0x1BF9820 Offset: 0x1BF9921 VA: 0x1BF9820
	public void DoClose() { }

	// RVA: 0x1BF9880 Offset: 0x1BF9981 VA: 0x1BF9880
	private void Update() { }

	// RVA: 0x1BF9AB0 Offset: 0x1BF9BB1 VA: 0x1BF9AB0
	public void .ctor() { }
}

