public class Fade : MonoBehaviour // TypeDefIndex: 7698
{
	// Fields
	private IFade fade; // 0x18
	[SerializeField] // RVA: 0x168B00 Offset: 0x168C01 VA: 0x168B00
	[RangeAttribute] // RVA: 0x168B00 Offset: 0x168C01 VA: 0x168B00
	private float cutoutRange; // 0x20
	[SerializeField] // RVA: 0x168B40 Offset: 0x168C41 VA: 0x168B40
	private GameObject parentObject; // 0x28
	[SerializeField] // RVA: 0x168B50 Offset: 0x168C51 VA: 0x168B50
	private GameObject objAnimChara; // 0x30
	private GameObject objAnimText; // 0x38
	private Image imgAnimChara; // 0x40
	private Image imgAnimText; // 0x48
	private Fade.FADE_STEP step; // 0x50

	// Methods

	// RVA: 0x2083330 Offset: 0x2083431 VA: 0x2083330
	private void Awake() { }

	// RVA: 0x2083460 Offset: 0x2083561 VA: 0x2083460
	private void Update() { }

	// RVA: 0x2083640 Offset: 0x2083741 VA: 0x2083640
	private void OnValidate() { }

	// RVA: 0x2083490 Offset: 0x2083591 VA: 0x2083490
	private void LoadLoadingAnim() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A27F0 Offset: 0x1A28F1 VA: 0x1A27F0
	// RVA: 0x2083710 Offset: 0x2083811 VA: 0x2083710
	private IEnumerator FadeoutCoroutine(float time, Action action, bool onLoad) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2860 Offset: 0x1A2961 VA: 0x1A2860
	// RVA: 0x2083800 Offset: 0x2083901 VA: 0x2083800
	private IEnumerator FadeinCoroutine(float time, Action action) { }

	// RVA: 0x20838E0 Offset: 0x20839E1 VA: 0x20838E0
	public Coroutine FadeOut(float time, Action action, Color color, bool onload) { }

	// RVA: 0x2083D40 Offset: 0x2083E41 VA: 0x2083D40
	public Coroutine FadeOut(float time) { }

	// RVA: 0x2083DA0 Offset: 0x2083EA1 VA: 0x2083DA0
	public Coroutine FadeIn(float time, Action action, Color color, bool onload) { }

	// RVA: 0x20841F0 Offset: 0x20842F1 VA: 0x20841F0
	public Coroutine FadeIn(float time) { }

	// RVA: 0x2084250 Offset: 0x2084351 VA: 0x2084250
	public void SetStep(Fade.FADE_STEP set_step) { }

	// RVA: 0x2084260 Offset: 0x2084361 VA: 0x2084260
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A28D0 Offset: 0x1A29D1 VA: 0x1A28D0
	// RVA: 0x2084270 Offset: 0x2084371 VA: 0x2084270
	private void <LoadLoadingAnim>b__12_0(AssetHandle<GameObject> handle) { }
}

