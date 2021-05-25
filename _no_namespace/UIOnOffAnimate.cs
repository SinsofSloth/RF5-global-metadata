public class UIOnOffAnimate : MonoBehaviour // TypeDefIndex: 8468
{
	// Fields
	private static List<UIOnOffAnimate> NowUsingList; // 0x0
	[SerializeField] // RVA: 0x16FCC0 Offset: 0x16FDC1 VA: 0x16FCC0
	[RangeAttribute] // RVA: 0x16FCC0 Offset: 0x16FDC1 VA: 0x16FCC0
	private float MoveTime; // 0x18
	[SerializeField] // RVA: 0x16FD10 Offset: 0x16FE11 VA: 0x16FD10
	private Vector2 StartPos; // 0x1C
	private Vector2 originPos; // 0x24
	private Vector2 targetPos; // 0x2C
	[SerializeField] // RVA: 0x16FD20 Offset: 0x16FE21 VA: 0x16FD20
	private bool BlockInputWhileAnimating; // 0x34
	[SerializeField] // RVA: 0x16FD30 Offset: 0x16FE31 VA: 0x16FD30
	private bool DestroyAfterEnded; // 0x35
	[CompilerGeneratedAttribute] // RVA: 0x16FD40 Offset: 0x16FE41 VA: 0x16FD40
	private bool <isOpen>k__BackingField; // 0x36
	[SerializeField] // RVA: 0x16FD50 Offset: 0x16FE51 VA: 0x16FD50
	private RectTransform TargetRect; // 0x38
	private float nTime; // 0x40
	[SerializeField] // RVA: 0x16FD60 Offset: 0x16FE61 VA: 0x16FD60
	private CanvasGroup canvasGroup; // 0x48
	[SerializeField] // RVA: 0x16FD70 Offset: 0x16FE71 VA: 0x16FD70
	private AnimationCurve slideCurve; // 0x50
	[SerializeField] // RVA: 0x16FD80 Offset: 0x16FE81 VA: 0x16FD80
	private AnimationCurve fadeCurve; // 0x58
	private float curveSpeed; // 0x60
	private float curveRate; // 0x64
	private bool isInit; // 0x68

	// Properties
	public static bool isAnimateInputBlocking { get; }
	public bool isOpen { get; set; }

	// Methods

	// RVA: 0x1EE6200 Offset: 0x1EE6301 VA: 0x1EE6200
	public static bool get_isAnimateInputBlocking() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A79A0 Offset: 0x1A7AA1 VA: 0x1A79A0
	// RVA: 0x1EE6280 Offset: 0x1EE6381 VA: 0x1EE6280
	public bool get_isOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A79B0 Offset: 0x1A7AB1 VA: 0x1A79B0
	// RVA: 0x1EE6290 Offset: 0x1EE6391 VA: 0x1EE6290
	private void set_isOpen(bool value) { }

	// RVA: 0x1EE62A0 Offset: 0x1EE63A1 VA: 0x1EE62A0
	private void Init() { }

	// RVA: 0x1EE6360 Offset: 0x1EE6461 VA: 0x1EE6360
	public void ForceClose() { }

	// RVA: 0x1EE6550 Offset: 0x1EE6651 VA: 0x1EE6550
	public void DoOpen() { }

	// RVA: 0x1EE6700 Offset: 0x1EE6801 VA: 0x1EE6700
	public void DoClose() { }

	// RVA: 0x1EE6850 Offset: 0x1EE6951 VA: 0x1EE6850
	private void OnOpened() { }

	// RVA: 0x1EE63A0 Offset: 0x1EE64A1 VA: 0x1EE63A0
	private void OnClosed() { }

	// RVA: 0x1EE6960 Offset: 0x1EE6A61 VA: 0x1EE6960
	private void Update() { }

	// RVA: 0x1EE6C60 Offset: 0x1EE6D61 VA: 0x1EE6C60
	public void .ctor() { }

	// RVA: 0x1EE6CF0 Offset: 0x1EE6DF1 VA: 0x1EE6CF0
	private static void .cctor() { }
}

