public class HUDFadeMove : MonoBehaviour // TypeDefIndex: 8563
{
	// Fields
	[SerializeField] // RVA: 0x1709B0 Offset: 0x170AB1 VA: 0x1709B0
	private Vector2 MoveRange; // 0x18
	[SerializeField] // RVA: 0x1709C0 Offset: 0x170AC1 VA: 0x1709C0
	private bool fadeScaleX; // 0x20
	[SerializeField] // RVA: 0x1709D0 Offset: 0x170AD1 VA: 0x1709D0
	private bool fadeAlpha; // 0x21
	[SerializeField] // RVA: 0x1709E0 Offset: 0x170AE1 VA: 0x1709E0
	private float fadeOutMax; // 0x24
	[SerializeField] // RVA: 0x1709F0 Offset: 0x170AF1 VA: 0x1709F0
	private float fadeInMax; // 0x28
	private CanvasGroup canvasGroup; // 0x30
	private AnimationCurve slideCurve; // 0x38
	private AnimationCurve fadeCurve; // 0x40
	private Vector2 startPos; // 0x48
	private Vector2 nowPos; // 0x50
	private Vector2 fadePos; // 0x58
	private Vector2 InstantPos; // 0x60
	private RectTransform RectTransform; // 0x68
	private HUDFadeMove.FadeStatus status; // 0x70
	private float fadeTimeCount; // 0x74
	private float nowFadeDelay; // 0x78
	private float forceFadeTime; // 0x7C
	private bool isForceFadeIn; // 0x80
	private float curveSpeed; // 0x84
	private float curveRate; // 0x88
	private bool isStartUp; // 0x8C

	// Methods

	// RVA: 0x1EC0B10 Offset: 0x1EC0C11 VA: 0x1EC0B10
	private void DnStartUp() { }

	// RVA: 0x1EC0C50 Offset: 0x1EC0D51 VA: 0x1EC0C50
	private void Awake() { }

	// RVA: 0x1EC0C60 Offset: 0x1EC0D61 VA: 0x1EC0C60
	private void LateUpdate() { }

	// RVA: 0x1EC0FF0 Offset: 0x1EC10F1 VA: 0x1EC0FF0
	private void OnDisable() { }

	// RVA: 0x1EBA8C0 Offset: 0x1EBA9C1 VA: 0x1EBA8C0
	public void ForceOut() { }

	// RVA: 0x1EBB460 Offset: 0x1EBB561 VA: 0x1EBB460
	public void SetFadeOut() { }

	// RVA: 0x1EBB420 Offset: 0x1EBB521 VA: 0x1EBB420
	public void SetFadeIn() { }

	// RVA: 0x1EC10B0 Offset: 0x1EC11B1 VA: 0x1EC10B0
	private void SetFade(float fadeDelayTime, Vector2 nextPos) { }

	// RVA: 0x1EC0FA0 Offset: 0x1EC10A1 VA: 0x1EC0FA0
	private void OnFadeEnd() { }

	// RVA: 0x1EC12A0 Offset: 0x1EC13A1 VA: 0x1EC12A0
	public void .ctor() { }
}

